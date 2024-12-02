using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace MyDrawing.presentationModel
{
    public class PresentationModel : INotifyPropertyChanged
    {
        Model model;
        public event EventHandler ButtonStateChanged;
        public event EventHandler ButtonStateCancled;

        // DataBinding
        public event PropertyChangedEventHandler PropertyChanged;

        private string SelectedButtonName;  //紀錄哪一個button被按
        public string shapeType = "null";
        public PresentationModel(Model model)
        {
            this.model = model;
        }
        public string SelectedButton
        {
            get => SelectedButtonName;
            set
            {
                if (SelectedButton != value) //如果不等於value 代表值改變(狀態改變)
                {
                    SelectedButtonName = value;
                    shapeType = value.ToString();
                    OnButtonStateChanged();
                }
                else
                {
                    OnButtonStateCancled();
                }
            }

        }
        public bool isStartChecked => SelectedButtonName == "Start"; //Name為指定的值，就為true，再傳回給view來更新ui
        public bool isTerminatorChecked => SelectedButtonName == "Terminator";
        public bool isProcessChecked => SelectedButtonName == "Process";
        public bool isDecisionChecked => SelectedButtonName == "Decision";

        protected virtual void OnButtonStateChanged()
        {
            ButtonStateChanged?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnButtonStateCancled()
        {
            ButtonStateCancled?.Invoke(this, EventArgs.Empty);
        }
        public void SetButtonChecked(string buttonName)
        {
            SelectedButton = buttonName;    //設定SelectedButton
        }
        public string CurrentType()
        {
            return shapeType;
        }

        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
