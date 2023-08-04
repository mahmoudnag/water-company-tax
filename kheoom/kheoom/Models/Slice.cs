using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace kheoom.Models
{
    public class Slice
    {
      
        public int Id { get; set; }

        public string Slice_Description { get; set; }

        public decimal ConsumptionValue_Slice { get; set; }

        public int BlockNumbers { get; set; }

        public decimal price_liter { get; set; }

       

        public decimal Price_Sanitation { get; set; }

        public string Notes { get; set; }



    }
}
