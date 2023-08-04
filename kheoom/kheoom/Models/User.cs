using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace kheoom.Models
{
    public class User
    {
        [Display(Name = "رقم الادمن")]
        public int Id { get; set; }

        [Display(Name = " اسم الادمن")]
        public string UserName { get; set;}

        [Display(Name = "كلمة المرور")]
        public string Password { get; set; }

    }
}
