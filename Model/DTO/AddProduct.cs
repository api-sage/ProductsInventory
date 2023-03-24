namespace ProductInventoryMgt.Model.DTO
{
    public class AddProduct
    {
        public string ProductName { get; set; }
        public int QtyReceived { get; set; }
        public int QtySold { get; set; }
        public string Status { get; set; }
    }
}
