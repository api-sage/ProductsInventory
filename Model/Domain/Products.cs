using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace ProductInventoryMgt.Model.Domain
{
    public class Products
    {
        [Key]
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int QtyReceived { get; set; }
        public int QtySold { get; set; }
        public string Status { get; set; }
    }
}
