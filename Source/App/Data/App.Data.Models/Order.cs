namespace App.Data.Models
{
    using System;

    public class Order
    {
        public int Id { get; set; }

        public DateTime MyProperty { get; set; }

        public bool Status { get; set; }

        public decimal Total { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
