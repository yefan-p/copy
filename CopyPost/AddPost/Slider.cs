using System;
using System.Collections.Generic;
using System.Linq;

namespace CopyPost
{
    class Slider<T>
    {
        int currentIndexSlide;
        List<T> sliderList;

        public event EventHandler onChangeSlide;

        public Slider(List<T> listObject)
        {
            currentIndexSlide = 0;
            sliderList = listObject;
        }

        public void Initialize()
        {
            onChangeSlide?.Invoke(this, EventArgs.Empty);
        }

        #region Общие действия со слайдом. Переключить или удалить слайд
        public void NextSlide()
        {
            if (sliderList.Count > 0)
                ChangeIndex(1);
        }

        public void PreviewSlide()
        {
            if (sliderList.Count > 0)
                ChangeIndex(-1);
        }

        public void DeleteSlide()
        {
            if (sliderList.Count > 0)
            {
                sliderList.RemoveAt(currentIndexSlide);
                ChangeIndex(0);
            }
        }
        #endregion

        #region Текущий слайд. Изменить или получить текущий слайд
        public T CurrentSlide
        {
            get 
            {
                if (sliderList.Count > 0)
                    return sliderList[currentIndexSlide];
                else
                {
                    T nullSlide = default(T);
                    return nullSlide;
                }                    
            }
            set
            {
                sliderList[currentIndexSlide] = value;
            }
        }
        #endregion

        #region Основные свойства. Индекс текущего слайда, количество слайдов, получить все слайды
        public int SlidesCount
        {
            get { return sliderList.Count(); }
        }

        public int IndexSlides
        {
            get { return currentIndexSlide; }
        }

        public List<T> Slides
        {
            get { return sliderList; }
        }
        #endregion

        #region Изменение индекса. Механизм контроля вылета индекса за пределы
        private void ChangeIndex(int step)
        {
            currentIndexSlide = currentIndexSlide + step;
            if (currentIndexSlide < 0)
                currentIndexSlide = sliderList.Count - 1;
            else if (currentIndexSlide >= sliderList.Count)
                currentIndexSlide = 0;

            onChangeSlide?.Invoke(this, EventArgs.Empty);
        }
        #endregion
    }
}
