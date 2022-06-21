using System.ComponentModel.DataAnnotations;

namespace ModelBindingMVC.Models
{
    //ModelBindingMVCV
    public class WebUser
    {       
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        [Required]
        [StringLength(25), MinLength(3)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(10), MinLength(3)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string MailAddress { get; set; }
    }
}
