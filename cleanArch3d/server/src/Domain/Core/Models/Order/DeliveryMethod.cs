using Domain.Common;

namespace Domain.Core.Models.Order
{
    public class DeliveryMethod : Entity
    {
        public string ShortName { get; set; }
        public string DeliveryTime { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}