using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace kheoom.ViewModels
{
    public class InvoiceVM
    {
        [Display(Name = "رقم الفاتورة")]
        public int System_InvoiceID { get; set; }
        [Display(Name = "  تاريخ الفاتورة")]
        public DateTime DataEntry { get; set; }

        [Display(Name = " من تاريخ")]
        public DateTime FromDate { get; set; }

        [Display(Name = " الي تاريخ")]
        public DateTime ToDate { get; set; }
     

        [Display(Name = "رقم الاشتراك")]

        public int System_SubscriptionID { get; set; }

        [Display(Name = "هوية المشترك")]
        public string SubscriberID { get; set; }

        [Display(Name = " الاسم")]
        public string SubscriberName { get; set; }

        [Display(Name = " القراء السابقة")]
        public decimal LastRead { get; set; }

        [Display(Name = " القراء الحال")]
        public decimal NowRead { get; set; }

        [Display(Name = " كمية الاستهلاك")]

        public decimal Consumption_Amount { get; set; }

      
        [Display(Name = "هل يوجد صرف صحي  ")]
        public string Sanitation { get; set; }

        [Display(Name = " عدد الوحدات")]

        public int subscription_BlockNumbers { get; set; }

        [Display(Name = " قيمة رسوم الخدمة")]
        public decimal Service_Fee { get; set; }

        [Display(Name = " نسبة الضريبة")]
        public decimal Tax_rate { get; set; }


        [Display(Name = " كمية استهلاك المياة")]

        public decimal ConsumptionValue_Water { get; set; }

        [Display(Name = "كمية استهلاك الصرف الصحي")]

        public decimal ConsumptionValue_Sanitation { get; set; }

        [Display(Name = "قيمة الفاتورة الهوية")]

        public decimal Invoice_Value_ { get; set; }

        [Display(Name = " اجمالي الفاتورة")]

        public decimal Invoice_All_Value_ { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [Display(Name = "ملاحظات")]
        public string Notes { get; set; }
    }
}
