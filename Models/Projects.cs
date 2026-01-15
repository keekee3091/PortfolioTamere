namespace PortfolioTamere.Models
{
    public class Project
    {
        public string Id { get; set; }         
        public string Title { get; set; }      
        public string Description { get; set; }
        public string Technologies { get; set; }
        public string Url { get; set; }
        public string FullDescription { get; set; }
        public string? SubProjects { get; set; }

    }
}
