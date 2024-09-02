using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVeiculos.Models
{
    internal class Validation
    {
        public void ClassValidation()
        {
            ValidationContext context = new ValidationContext(this, serviceProvider:  null, items: null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            if (!isValid)
            {
                StringBuilder sb = new StringBuilder();
                foreach (ValidationResult result in results)
                {
                    sb.Append(result.ErrorMessage);
                }
                throw new ValidationException(sb.ToString());
            }
        }
    }
}
