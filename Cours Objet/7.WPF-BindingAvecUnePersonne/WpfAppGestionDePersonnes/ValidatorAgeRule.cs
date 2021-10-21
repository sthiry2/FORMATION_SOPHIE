using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppGestionDePersonnes
{
    public class ValidatorAgeRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int valueAge;
            bool ok = int.TryParse(value.ToString(), out valueAge);
            if (ok == false)
            {
                return new ValidationResult(false, "Please enter a number");
            }
            else if (valueAge < 18)
            {
                return new ValidationResult(false, "Please enter age valid");
            }
            else
            {
                return ValidationResult.ValidResult;
            }


        }
    }
}
