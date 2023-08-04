using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace kheoom.Models
{
    public class SubScribption
    {
        
        public int Id { get; set; }
        [Display(Name = " رقم الاشتراك")]
        public int SystemsubsriptionId { get; set; }
        [Display(Name = "رقم الهوية ")]
        public string SubscriberID { get; set; }
        [Display(Name = "الاسم ")]
        public string SubscriberName { get; set; }
        [Display(Name = "المدينة ")]
        public string city { get; set; }
        [Display(Name = "الحي ")]
        public string area { get; set; }
        [Display(Name = "عدد الوحدات")]
        public int BlockNumbers{ get; set; }

        [Display(Name = "نوع العقار ")]
        public string BlockType{ get; set; }
        [Display(Name = "الجوال ")]
        public string phone { get; set; }

        [Display(Name = "الاسم ")]
        public decimal LastRead { get; set; }
        [Display(Name = "هل يوجد صرف صحي")]
        public string Sanitation { get; set; }
        [Display(Name = "ملاحظات")]
        public string Notes { get; set; }

    }
}
