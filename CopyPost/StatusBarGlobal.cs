using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPost
{
    class StatusBarGlobal
    {
        string descriptionLable;
        string messageLabel;
        int progressValue;
        bool visibleProgress;

        public event EventHandler onChangeDescription;
        public event EventHandler onChangeMessage;
        public event EventHandler onChangeProgress;

        public bool VisibleProgress
        {
            get { return visibleProgress; }
        }

        public string Description
        {
            get { return descriptionLable; }
            set
            {
                descriptionLable = value;
                onChangeDescription(this, EventArgs.Empty);
            }
        }

        public string Message
        {
            get { return messageLabel; }
            set
            {
                messageLabel = value;
                onChangeMessage(this, EventArgs.Empty);
            }
        }

        public int Progress
        {
            get { return progressValue; }
        }

        public void SetProgress(int currentValue, int maxValue)
        {
            if (currentValue == 0)
                currentValue = 1;

            progressValue = maxValue * 100 / currentValue;

            onChangeProgress(this, EventArgs.Empty);

            if (progressValue > 0)
                visibleProgress = true;
            else
                visibleProgress = false;
        }
    }
}
