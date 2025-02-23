using KnowledgeBase.Models;
using KnowledgeBase.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;

namespace KnowledgeBase
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HeroesRussiaService _heroesRussiaService;
        
        List<HeroesRussiaVM> _heroesRussiaList;

        public MainWindow()
        {
            InitializeComponent();
            _heroesRussiaService = new HeroesRussiaService();
            _heroesRussiaList = _heroesRussiaService.GetAll();

            this.DataContext = _heroesRussiaList.FirstOrDefault();
        }
    }
}
