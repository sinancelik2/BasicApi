using App.Domain.Common;

namespace App.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public decimal Value { get; set; }

        public int Quantity { get; set; }
    }
}
