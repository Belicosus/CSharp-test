using System.ComponentModel;

namespace Opg2.Model
{
    public class Product : BaseModel
    {
        
        public int DefaultPrice { get; set; }

        public ProductPrice ProductPrice { get; set; }
        
        public int NumOfSales { get; set; }
    }
}