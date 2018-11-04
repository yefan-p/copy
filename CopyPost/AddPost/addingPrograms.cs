using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyPost
{
    class addingPrograms
    {
        public static void NewProgram(string name, string site, string platformId, DataGridViewSelectedRowCollection selectedCategoriesId)
        {
            List<DataBase.SQLParam> param = new List<DataBase.SQLParam>();
            param = DataBase.AddParam(param, "var_name", name);
            param = DataBase.AddParam(param, "var_href", site);
            param = DataBase.AddParam(param, "var_platform", platformId);

            DataBase dataBase = new DataBase();
            string sql =
                        @"INSERT INTO
	                        programs
                            (name, off_site, platform_id)
                            VALUES
                            ('var_name', 'var_href', var_platform)";

            dataBase.SendReqestNoAnswer(sql, param);
            SetCategoris(selectedCategoriesId);
        }

        private static void SetCategoris(DataGridViewSelectedRowCollection selectedCategoriesId)
        {
            string programsId = GetLastRecordPrograms();
            foreach (DataGridViewRow item in selectedCategoriesId)
            {
                int categoriesId = item.Index + 1;
                SendCategory(programsId, categoriesId.ToString());
            }
        }

        private static string GetLastRecordPrograms()
        {
            DataBase db = new DataBase();

            string sql =
                        @"SELECT 
                            id
                        FROM
                            programs
                        ORDER BY id DESC
                        LIMIT 1";

            DataTable dt = db.SendReqest(sql);
            DataRow dataRow = dt.Rows[0];
            string record = dataRow.ItemArray[0].ToString();
            return record;
        }

        private static void SendCategory(string programsId, string categoriesId)
        {
            List<DataBase.SQLParam> param = new List<DataBase.SQLParam>();
            param = DataBase.AddParam(param, "var_programs", programsId);
            param = DataBase.AddParam(param, "var_categories", categoriesId);

            DataBase dataBase = new DataBase();
            string sql =
                        @"INSERT INTO
	                        program_categories
                            (categories_id, programs_id)
                            VALUES
                            (var_categories, var_programs)";

            dataBase.SendReqestNoAnswer(sql, param);
        }
    }
}
