public class StoreModels
{
    /// <summary>
    /// DB Primary key
    /// </summary>
    public int ID { get; set; }
    public List<string>? StoreNames { get; set; }
    /// <summary>
    /// For products
    /// </summary>
    public List<ProductReposityDTO>? ProductRepository { get; set; }
}