using KnowledgeBase.Models;
using KnowledgeBase.Services;
using System.Collections.Generic;
using System.Linq;

namespace KnowledgeBase.ViewModels
{
    public class MainWindowVM : BaseNotifyPropertyChanged
    {
       private List<HeroesRussiaVM> _heroesRussiaListVM { get; set; }
       private HeroesRussiaVM _currentHero { get; set; }

        public List<HeroesRussiaVM> HeroesRussiaListVM
        {
            get { return _heroesRussiaListVM; }
            set
            {
                _heroesRussiaListVM = value;
                OnPropertyChanged("HeroesRussiaListVM");
            }
        }

        public HeroesRussiaVM CurrentHero
        {
            get { return _currentHero; }
            set
            {
                _currentHero = value;
                OnPropertyChanged("CurrentHero");
            }
        }

        public void InitVM()
        {
            HeroesRussiaService heroesRussiaService = new HeroesRussiaService();

            HeroesRussiaListVM = heroesRussiaService.GetAll();
            CurrentHero = HeroesRussiaListVM.FirstOrDefault();
        }
    }
}
