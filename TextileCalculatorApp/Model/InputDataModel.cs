using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;



namespace TextileCalculatorApp.Model
{
    class InputDataModel
    {

    }

    public class InputData : INotifyPropertyChanged
    {
        private string inputLength;

        private string inputNumber;

        private string selectedSuspension;

        private string inputFactor;

        public string InputLength
        {
            get { return inputLength; }
            
            set
            {
                if (inputLength != value)
                {
                    inputLength = value;
                    RaisePropertyChanged("InputLength");
                }
            }
        }

        public string InputNumber
        {
            get { return inputNumber; }

            set
            {
                if (inputNumber != value)
                {
                    inputNumber = value;
                    RaisePropertyChanged("InputNumber");
                }
            }
        }

        public string SelectedSuspension
        {
            get { return selectedSuspension; }

            set
            {
                if (selectedSuspension != value)
                {
                    selectedSuspension = value;
                    RaisePropertyChanged("SelectedSuspension");
                }
            }
        }

        public string InputFactor
        {
            get { return inputFactor; }

            set
            {
                if (inputFactor != value)
                {
                    inputFactor = value;
                    RaisePropertyChanged("InputFactor");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }

    
}


