using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppGestionDePersonnes.Validators
{
    public class ValidationChaineDeCaractere : ValidationRule
    {
        public string ErrorMessage { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var result = new ValidationResult(true, null);

            var name = Convert.ToString(value);
            foreach (var c in name)
            {
                if (Char.IsDigit(c))
                {
                    result = new ValidationResult(false, this.ErrorMessage);
                    return result;
                }
            }
            return result;
        }
    }
}
