namespace App.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Image
    {
        [Key]
        public int Id { get; set; }

        public string ImagePath { get; set; }

        public string Link { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int Ordered { get; set; }
    }
}
