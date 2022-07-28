using System.ComponentModel.DataAnnotations;

namespace ProjectX.Models
{
    public class User
    {
        [Display(ResourceType = typeof(Resources.Resources), Name = "name")]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "required")]
        [StringLength(30, ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "maxLength")]

        public string Name { set; get; }

        [Display(ResourceType = typeof(Resources.Resources), Name = "email")]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "required")]
        [RegularExpression(@"^[_A-Za-z0-9-]+(\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9-]+)*(\.[A-Za-z]{2,4})$", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "emailError")]
        public string Address { set; get; }
    }
}