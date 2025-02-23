using KnowledgeBase.ViewModels;

namespace KnowledgeBase.Models
{
    public class HeroesRussiaVM : BaseNotifyPropertyChanged
    {
        private int _id { get; set; }
        private string _title { get; set; }
        private string _description { get; set; }
        private string? _imageUrl { get; set; }

        public HeroesRussiaVM(int id, string title, string description, string? imageUrl)
        {
            Id = id;
            Title = title;
            Description = description;
            ImageUrl = imageUrl;
        }

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }

        public string? ImageUrl
        {
            get { return _imageUrl; }
            set
            {
                _imageUrl = value;
                OnPropertyChanged("ImageUrl");
            }
        }
    }
}
