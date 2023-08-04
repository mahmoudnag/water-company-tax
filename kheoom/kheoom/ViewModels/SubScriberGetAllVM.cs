using DocumentFormat.OpenXml.Wordprocessing;
using System.ComponentModel.DataAnnotations;

namespace kheoom.ViewModels
{
    public class SubScriberGetAllVM
    {
        [Display(Name = "رقم الهوية")]
        public string IdIdentity { get; set; }
        [Display(Name = "الاسم ")]

        public string Name { get; set; }

        [Display(Name = "المدينة")]


        public string city { get; set; }

        [Display(Name = "الحي")]

        public string area { get; set; }

        [Display(Name = "رقم الجوال")]

        public string phone { get; set; }
        [Display(Name = "عدد الاشتراكات")]
        public int subscriptionNumbers { get; set; }
    }
}
