using kheoom.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace kheoom.ViewModels
{
    public class SubScriberVM
    {
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رقم الهوية")]
        public string IdIdentity { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الاسم ")]

        public string Name { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]

        [Display(Name = "المدينة")]


        public string city { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]

        [Display(Name = "الحي")]

        public string area { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]

        [Display(Name = "رقم الجوال")]

        public string phone { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
       
        [Display(Name = "ملاحظات")]
        public string Notes { get; set; }

    }
}
