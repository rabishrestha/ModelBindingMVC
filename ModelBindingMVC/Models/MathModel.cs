using System.ComponentModel.DataAnnotations;

namespace ModelBindingMVC.Models
{
    public class MathModel
    {
        [Required]
        [Range (1, 10000) ]
        [Display(Name = "First Number")]
        public double num1 { get; set; } = 0;
        [Required]
        [Range(1, 10000)]
        [Display(Name = "Second Number")]
        public double num2 { get; set; } = 0;
        [Display(Name = "Operator")]
        public string ops { get; set; } = "";

        public double Calculate()
        {
            double c;
            if (ops == "+") { c = num1 + num2; } 
            else if(ops == "-") { c = num1 - num2; }
            else if (ops == "*") { c = num1 * num2; }
            else if (ops == "/") { c = num1 / num2; }
            else { c = 0; }
            return c;
        }
    }
}
