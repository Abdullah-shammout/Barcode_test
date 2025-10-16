using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barcode.Models
{
    public class BarcodeTypes
    {
        [Key]
        public int BarcodeId { get; set; }
        public string Barcode { get; set; }
    }
}
