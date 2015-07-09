using System;
using System.Collections.Generic;
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

namespace Recette.View
{
    /// <summary>
    /// Interaction logic for TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Page
    {
        public TestWindow()
        {
            InitializeComponent();
            List<string> names = new List<string>();
            names.Add("Anand");
            names.Add("Arun");
            names.Add("Arjun");
            names.Add("Arul");
            names.Add("Arula");
            names.Add("Arule");
            names.Add("Bala");
            names.Add("Balaji");
            names.Add("Barani");
            names.Add("Buji");
            names.Add("Brasil");
            autoComplete.ItemsSource = names;
        }

        static int Clicks = 0;
        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            Clicks += 1;
            clickTextBlock.Text = "Number of Clicks: " + Clicks;
        }
    }
}
