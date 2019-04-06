using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyPostCore;
using CopyPostCore.DataBase;
using CopyPostCore.Parsers;

namespace UpdateDatabase
{
    class MainPresenter
    {
        public MainPresenter()
        {

        }

        public int Refresh()
        {
            ParserRutor parserRutor = new ParserRutor();
            List<FoundPost> foundPosts = parserRutor.GetList();

            DataBaseControl dataBase = new DataBaseControl();
            List<FoundPost> oldFoundPosts = dataBase.GetLastFounded(TTrakers.Rutor, 500);

            foundPosts = parserRutor.DeleteDuplicateFromList(oldFoundPosts, foundPosts);
            List<ReadyPost> readyPosts = parserRutor.GetItems(foundPosts);

            int result = dataBase.AddReady(readyPosts);
            return result;
        }
    }
}
