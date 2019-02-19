using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPost.Parsers
{
    public class ParserRutor
    {
        private static readonly Uri UriDotInfo = new Uri(@"http://www.rutor.info/soft");
        private static readonly Uri UriDotIs = new Uri(@"http://rutor.is/soft");
        private static readonly Uri UriDotOnion = new Uri(@"http://rutorc6mqdinc4cz.onion/soft");
        public static readonly Uri UriWork = UriDotIs;

        /// <summary>
        /// Возвращает список новых раздач
        /// </summary>
        public void GetList()
        {

        }
    }
}
