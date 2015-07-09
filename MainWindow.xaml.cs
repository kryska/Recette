using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Recette.View;

namespace Recette
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> names = new List<string>();
            names.Add("Add item");
            names.Add("Import recipe");
            cboRecipes.ItemsSource = names;
            WindowState = WindowState.Maximized;
            //btnRecipes.Visibility = Visibility.Collapsed;
        }

        private void Open_Click(object sender, RoutedEventArgs e) 
        {
            //TestWindow wind = new TestWindow();
            //wind.Show();
            // me.NavigationService.Navigate(new TestWindow());
            fraCentral.NavigationService.Navigate(new TestWindow());
        }

        private void btnGrossery_Click(object sender, RoutedEventArgs e)
        {
            fraCentral.NavigationService.Navigate(new TestWindow());
        }

        private void btnRecipes_Click(object sender, RoutedEventArgs e)
        {
            //cboRecipes.MouseDown(cboRecipes, new MouseButtonEventArgs(mouse, 0, MouseButton.Left));
            cboRecipes.IsDropDownOpen = true;
        }
    }
}
