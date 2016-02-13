namespace App.Data.Models
{
    public class PromotionItem
    {
        public int Id { get; set; }

        public int PromotionId { get; set; }

        public virtual Promotion Propmotion { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public decimal Discount { get; set; }

        public int Percent { get; set; }
    }
}
