using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CS_MVC_Lab_5.Models
{
    public class OperationModel
    {
        [Required(ErrorMessage = "Некоректное число. Используете цифры от 0 до 9 и знак ','")]
        [RegularExpression(@"^[-+]?[0-9]*[,]?[0-9]+$")]
        public double X { get; set; }

        [Required(ErrorMessage = "Некоректное число. Используете цифры от 0 до 9 и знак ','")]
        [RegularExpression(@"^[-+]?[0-9]*[,]?[0-9]+$")]
        public double Y { get; set; }
        public double Result { get; set; }

    }
}
