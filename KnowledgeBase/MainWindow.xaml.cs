using KnowledgeBase.Models;
using KnowledgeBase.Services;
using KnowledgeBase.ViewModels;
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

        public MainWindow()
        {
            InitializeComponent();
            MainWindowVM mainWindowVM = new MainWindowVM();
            mainWindowVM.InitVM();

            this.DataContext = mainWindowVM;
        }
    }
}
