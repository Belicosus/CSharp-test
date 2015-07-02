namespace Opg2.Model
{
    public class Customer : BaseModel
    {
        public string FirsteName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
    }
}