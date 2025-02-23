using KnowledgeBase.Services;
using System;
using System.Windows;

namespace KnowledgeBase
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HeroesRussiaService _heroesRussiaService;
        public MainWindow()
        {
            InitializeComponent();
            _heroesRussiaService = new HeroesRussiaService();
        }

        async private void Button_Click(object sender, RoutedEventArgs e)
        {
            var list = await _heroesRussiaService.GetAll();

            Console.WriteLine();
        }
    }
}
