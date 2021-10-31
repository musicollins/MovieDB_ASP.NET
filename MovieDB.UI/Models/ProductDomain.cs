using System;

namespace MovieDB.UI.Models
{
    public class ProductDomain
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
    }

    public class PhysicalProductDomain : ProductDomain
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
    public class DigitalProductDomain : ProductDomain
    {
        public long LicenseNo { get; set; }

    }
}
