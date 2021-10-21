using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppGestionDePersonnes.ViewModels
{
    public class ViewModel : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        #region INotifyDataErrorInfo
        private Dictionary<string, List<string>> errors = new Dictionary<string, List<string>>();
        public bool HasErrors
        {
            get
            {
                return (errors.Count > 0);
            }
        }

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName) || !errors.ContainsKey(propertyName))
                return null;

            return errors[propertyName];
        }

        public void AddError(string propertyName, string errorMessage)
        {
            if (errors.ContainsKey(propertyName))
            {
                ICollection<string> errorsOfThisProperties = errors[propertyName];
                if (!errorsOfThisProperties.Contains(errorMessage))
                {
                    errorsOfThisProperties.Add(errorMessage);
                }
            }
            else
            {
                List<string> newErrorsOfThisProperties = new List<string>();
                newErrorsOfThisProperties.Add(errorMessage);
                errors.Add(propertyName, newErrorsOfThisProperties);
            }
            RaiseErrorsChanged(propertyName);
        }

        public void ClearError(string propertyName)
        {
            if (errors.ContainsKey(propertyName))
            {
                errors.Remove(propertyName);
                RaiseErrorsChanged(propertyName);
            }
  
        }

        private void RaiseErrorsChanged(string propertyName)
        {
            if (ErrorsChanged != null)
            {
                ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
            }
        }



        #endregion


        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaiseOnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        #endregion
    }
}
