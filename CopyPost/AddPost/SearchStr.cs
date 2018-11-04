using System;

namespace CopyPost
{
    class SearchStr
    {
        string nameProgram;
        int countShowWord;

        public event EventHandler onChangeName;

        public SearchStr(string _NameProgram)
        {
            nameProgram = _NameProgram;
            countShowWord = 1;
        }

        public void AddWord()
        {
            countShowWord++;
            onChangeName?.Invoke(this, EventArgs.Empty);
        }

        public void DeleteWord()
        {
            countShowWord--;
            onChangeName?.Invoke(this, EventArgs.Empty);
        }

        public string ShortName
        {
            get
            {
                string[] nameArr = nameProgram.Split(new char[] { ' ' }, 200);
                int maxLength = nameArr.Length;

                if (countShowWord < 0)
                    countShowWord = 0;
                else if (countShowWord >= maxLength)
                    countShowWord = maxLength - 1;

                string shortName = String.Join(" ", nameArr, 0, countShowWord + 1);
                return shortName;
            }
        }
    }
}
