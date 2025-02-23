namespace KnowledgeBase.Models
{
    public class HeroesRussiaVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }

        public HeroesRussiaVM(int id, string title, string description, string? imageUrl)
        {
            Id = id;
            Title = title;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
