


using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace kheoom.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int System_InvoiceID { get; set; }

     
        public DateTime DataEntry { get; set; }

        public DateTime  FromDate{ get; set; }

        public DateTime ToDate { get; set; }

        public int System_SubscriptionID { get; set; }

        public string SubscriberID { get; set; }

        public string SubscriberName { get; set; }

        public decimal LastRead { get; set; }

        public decimal NowRead { get; set; }

        public decimal Consumption_Amount { get; set; }

        //not added to db
        public string Sanitation { get; set; }

     

        public int subscription_BlockNumbers { get; set; }

        public decimal Service_Fee { get; set; }

        public decimal Tax_rate { get; set; }
       

        public decimal ConsumptionValue_Water{ get; set; }

        public decimal ConsumptionValue_Sanitation { get; set; }

 

        public decimal Invoice_Value_ { get; set; }

      

        public decimal Invoice_All_Value{ get; set; }
        public string Notes { get; set; }


    }
}
