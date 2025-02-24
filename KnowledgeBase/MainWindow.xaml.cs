using KnowledgeBase.Models;
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
        public MainWindow()
        {
            InitializeComponent();
            _mainWindowVM = new MainWindowVM();

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
    }
}
