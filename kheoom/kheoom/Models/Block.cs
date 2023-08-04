


using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace kheoom.Models
{
    public class Block
    {
        public int Id { get; set; }
        public string BlockId { get; set; }
       public string Name { get; set; }
        public string Notes { get; set; }
    }
}
