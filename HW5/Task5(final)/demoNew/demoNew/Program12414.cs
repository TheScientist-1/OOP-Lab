namespace demoNew
{
    public class Item
    {
        public string? Name { get; set; }
        public string? Price { get; set; }
        public string? CountryOfOrigin { get; set; }
        public string? PackageDate { get; set; }
        public string? Description { get; set; }

        virtual public string NumberOfPages { get; set; }
        virtual public string Publisher { get; set; }
        virtual public string Authors { get; set; }
        virtual public string ExpirationDate { get; set; }
        virtual public string Number { get; set; }
        virtual public string Unit { get; set; }
        
    }


    class Product : Item
    {
        override public string? ExpirationDate { get; set; } 
        override public string? Number { get; set; } 
        override public string? Unit { get; set; } 
    }
    public class Book : Item
    {
        override public string? NumberOfPages { get; set; } 
        override public string? Publisher { get; set; } 
        override public string? Authors { get; set; } 
    }
}
