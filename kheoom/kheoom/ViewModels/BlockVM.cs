using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace kheoom.ViewModels
{
   
    public class BlockVM
    {
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "رمز العقار")]
        public string BlockId { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]

        [Display(Name = "وصف العقار")]
        public string Name { get; set; }

        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "ملاحظات")]
        public string Notes { get; set; }
    }
}
