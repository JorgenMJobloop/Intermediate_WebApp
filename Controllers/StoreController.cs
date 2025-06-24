using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api")]
public class StoreController : ControllerBase
{
    private List<StoreModels> storeModels = new List<StoreModels>()
    {
        new StoreModels
        {
            ID = 1, StoreNames = ["Komplett", "Power", "Elkjøp", "Proshop", "Multi", "NetOnNet"],
            ProductRepository = new List<ProductReposityDTO>()
            {
                new ProductReposityDTO
                {
                    ProductID = 1, NameOfProduct = "Amd Ryzen 5 5600 Tray CPU",
                    ProductDescriptor = "An AMD Ryzen CPU",
                    ProductType = "Hardware/CPU",
                    Prices = 1559, Barcode = Guid.NewGuid()
                },

                new ProductReposityDTO
                {
                    ProductID = 2,
                    NameOfProduct = "Intel Core i5-12400F CPU Tray",
                    ProductDescriptor = "Intel Core i5 CPU",
                    ProductType = "Hardware/CPU",
                    Prices = 1428,
                    Barcode = Guid.NewGuid()
                }
            }
        },

        new StoreModels
        {

            ID = 2, StoreNames = ["Rema 1000", "Kiwi","Meny","Spar","Coop"],

            ProductRepository = new List<ProductReposityDTO>()
            {
                new ProductReposityDTO
                {
                    ProductID = 1, NameOfProduct = "Coca Cola",
                    ProductDescriptor = "A sugary soft-drink",
                    ProductType = "Groceries/Food",
                    Prices = 49,
                    Barcode = Guid.NewGuid()
                },

                new ProductReposityDTO
                {
                    ProductID = 2,
                    NameOfProduct = "Fanta",
                    ProductDescriptor = "A sugary soft-drink",
                    ProductType = "Groceries/Food",
                    Prices = 49,
                    Barcode = Guid.NewGuid()
                },
            }
        },

        new StoreModels
        { ID = 3, StoreNames = ["Platekompaniet"],
        ProductRepository = new List<ProductReposityDTO>()
        {
            new ProductReposityDTO
            {
                ProductID = 1,
                NameOfProduct = "Fight Club",
                ProductDescriptor = "A Blu-ray of Fight Club",
                ProductType = "Multimedia/Blu-ray",
                Prices = 99,
                Barcode = Guid.NewGuid()
            }
        },


        },
        new StoreModels {ID = 4, StoreNames = ["Felleskjøpet"], ProductRepository = [
            new ProductReposityDTO
                {
                    ProductID = 1,
                    NameOfProduct = "Manure",
                    ProductDescriptor = "A maure for large fields & farms",
                    ProductType = "Farming/Equipment",
                    Prices = 250,
                    Barcode = Guid.NewGuid()
                }
            ]
        }

    };

    [HttpGet("items")]
    public ActionResult<IEnumerable<StoreModels>> Get()
    {
        return Ok(storeModels.ToList());
    }
}