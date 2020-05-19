using System;
using Domain.Common;

namespace Domain.Core.Models.Product
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public ProductType ProductType { get; set; }
        public Guid ProductTypeId { get; set; }
        public ProductBrand ProductBrand { get; set; }
        public Guid ProductBrandId { get; set; }
    }
}