using kheoom.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace kheoom.ViewModels
{
    public class SubScribptionVM
    {
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = " رقم الاشتراك")]
        public int SystemsubsriptionId {get; set;}
        [Required(ErrorMessage = "هذا الحقل مطلوب")]

        [Display(Name = "رقم الهوية ")]
        [ForeignKey("SubScriber")]
        public string SubscriberID { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الاسم ")]
        public string SubscriberName { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "المدينة ")]
        public string city { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "الحي ")]
        public string area { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]

        [Display(Name = "عدد الوحدات ")]
        public int BlockNumbers { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]

        [Display(Name = "نوع العقار ")]
        public string BlockType { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]

        [Display(Name = "الجوال ")]
        public string phone { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
       
        public decimal LastRead { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "هل يوجد صرف صحي")]
        public string Sanitation { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]

        [Display(Name = "ملاحظات")]

        public string Notes { get; set; }

    }
}
