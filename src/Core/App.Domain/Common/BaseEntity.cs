using System;

namespace App.Domain.Common
{
   public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
