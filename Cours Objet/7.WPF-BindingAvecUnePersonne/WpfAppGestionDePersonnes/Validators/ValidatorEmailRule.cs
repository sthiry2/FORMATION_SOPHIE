using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppGestionDePersonnes.Validators
{
    public class ValidatorEmailRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            Match match = regex.Match(value.ToString());
            if (match == null || match == Match.Empty)
            {
                return new ValidationResult(false, "Please enter valid email");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }
    }
}
