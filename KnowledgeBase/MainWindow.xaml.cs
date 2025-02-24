using KnowledgeBase.Models;
using KnowledgeBase.Services;
using KnowledgeBase.ViewModels;
using System.Windows;
using System.Windows.Controls;


namespace KnowledgeBase
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM _mainWindowVM;
        private HeroesRussiaService _heroesRussiaService;

        public MainWindow()
        {
            InitializeComponent();
            _mainWindowVM = new MainWindowVM();
            _heroesRussiaService = new HeroesRussiaService();

            _mainWindowVM.InitVM();

            DataContext = _mainWindowVM;
            HeroesRussiaListBox.SelectedIndex = 0;
        }

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var selectedHero = (sender as ListBox).SelectedItem as HeroesRussiaVM;

            if(selectedHero != null)
            {
                _mainWindowVM.CurrentHero = selectedHero;
            }
        }

        async private void SearchInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchInput.Text != "") SearchInputPlaceholder.Visibility = Visibility.Hidden;
            else SearchInputPlaceholder.Visibility = Visibility.Visible;

            var result = await _heroesRussiaService.Search(SearchInput.Text);

            _mainWindowVM.HeroesRussiaListVM = result;
        }
    }
}
