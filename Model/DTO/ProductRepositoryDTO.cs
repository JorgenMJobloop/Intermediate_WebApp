public class ProductReposityDTO
{
    public int ProductID { get; set; }
    public string? NameOfProduct { get; set; }
    public string? ProductDescriptor { get; set; }
    public string? ProductType { get; set; }
    public double Prices { get; set; }
    public Guid Barcode { get; set; } = Guid.NewGuid();
}