using KnowledgeBase.ViewModels;
using System;

namespace KnowledgeBase.Models
{
    public class HeroesRussiaVM : BaseNotifyPropertyChanged
    {
        private int _id { get; set; }
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private string? _middleName { get; set; }
        private string? _biography { get; set; }
        private string? _placeBirth { get; set; }
        private DateTime? _birthDate { get; set; }
        private string? _imageUrl { get; set; }
     
        public HeroesRussiaVM(int id, string firstName, string lastName, string middleName, string biography, string placeBirth, string imageUrl, DateTime? birthDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Biography = biography;
            PlaceBirth = placeBirth;
            ImageUrl = imageUrl;
            BirthDate = birthDate;
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

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string? MiddleName
        {
            get { return _middleName; }
            set
            {
                _middleName = value;
                OnPropertyChanged("MiddleName");
            }
        }

        public string? Biography
        {
            get { return _biography; }
            set
            {
                _biography = value;
                OnPropertyChanged("Biography");
            }
        }

        public string? PlaceBirth
        {
            get { return _placeBirth; }
            set
            {
                _placeBirth = value ?? "Не указано";
                OnPropertyChanged("PlaceBirth");
            }
        }

        public DateTime? BirthDate
        {
            get { return _birthDate; }
            set
            {
                _birthDate = value ;
                OnPropertyChanged("BirthDate");
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

        public string FullFIO
        {
            get { return $"{_lastName} {_firstName} {_middleName}"; }
        }
    }
}
