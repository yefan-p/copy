using System;
using System.Collections.Generic;
using System.Linq;
using CopyPost.Trackers;

namespace CopyPost
{
    class PostList
    {
        mydbContext context = new mydbContext();

        //dw событие, которое происходит после добавления записей в бд
        public event EventHandler OnAfterAdd;

        //dw вызывает событие добавления записей в бд, нужно для обновления формы
        public void Initialize()
        {
            OnAfterAdd?.Invoke(this, EventArgs.Empty);
        }

        public void Add(ITrackersList t)
        {
            //dw подписываемся на событие получения списка постов
            //и инициализируем событие
            t.OnPostReceived += T_OnPostReceived;
            t.GetList();
        }

        private void T_OnPostReceived(object sender, RutorListEventArgs e)
        {
            //dw возвращаем объект из события
            RutorList tracker = sender as RutorList;
            //dw если бд пустая, просто добавляем в бд
            //инчае нужно делать проверку на дубликаты
            if (context.preposts.Count() == 0)
            {
                AddPostInDB(e.Posts, tracker.ExpressionDb);
                return;
            }

            //dw проверка на дубликаты записей в бд
            List<TrackersListItem> listNew = new List<TrackersListItem>();
            foreach (var item in e.Posts.OrderBy(it => it.Index))
            {
                preposts result = context.preposts.SingleOrDefault(it => it.magnet == item.Magnet);
                if (result == null)
                    listNew.Add(item);
            }
            listNew = listNew.OrderByDescending(it => it.Index).ToList();
            AddPostInDB(listNew, tracker.ExpressionDb);
        }

        private void AddPostInDB(List<TrackersListItem> lst, Func<tracker, bool> tExpression)
        {
            tracker t = context.tracker.Single(tExpression);

            foreach (var item in lst)
            {
                preposts prepost = new preposts
                {
                    name = item.Name,
                    href = item.Href,
                    date = DateTime.Today,
                    itpublic = 0,
                    tracker1 = t,
                    magnet = item.Magnet,
                };
                context.preposts.Add(prepost);
            }
            context.SaveChanges();
            //dw вызываем событие после добавления в бд
            OnAfterAdd?.Invoke(this, EventArgs.Empty);
        }
    }
}
