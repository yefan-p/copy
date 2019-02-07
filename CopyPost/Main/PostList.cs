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
        public event EventHandler onAfterAdd;

        //dw вызывает событие добавления записей в бд, нужно для обновления формы
        public void Initialize()
        {
            onAfterAdd?.Invoke(this, EventArgs.Empty);
        }

        public void Add(ITrackersList t)
        {
            //dw если бд пустая, просто добавляем в бд
            //инчае нужно делать проверку на дубликаты
            if (context.preposts.Count() == 0)
            {
                AddPostInDB(t.Posts, t.TrackerExpression);
                return;
            }

            //dw проверка на дубликаты записей в бд
            List<TrackersListItem> listNew = new List<TrackersListItem>();
            foreach (var item in t.Posts.OrderBy(it => it.Index))
            {
                preposts result = context.preposts.SingleOrDefault(it => it.href == item.Href);
                if (result == null)
                    listNew.Add(item);
            }
            listNew = listNew.OrderByDescending(it => it.Index).ToList();
            AddPostInDB(listNew, t.TrackerExpression);
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
                    tracker1 = t
                };
                context.preposts.Add(prepost);
            }
            context.SaveChanges();
            onAfterAdd?.Invoke(this, EventArgs.Empty);
        }
    }
}
