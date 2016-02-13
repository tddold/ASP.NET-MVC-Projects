namespace App.Data.Models
{
    public class Page
    {
        public int Id { get; set; }

        public string Link { get; set; }

        public bool ShowOnNav { get; set; }

        public string PageTitle { get; set; }

        public string  PageContent { get; set; }
    }
}
