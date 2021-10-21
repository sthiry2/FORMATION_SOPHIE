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
using WpfAppGestionDePersonnes.ViewModels;

namespace WpfAppGestionDePersonnes
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModelPersonne(new CLPersonne.Personne("thiry","s",3));


        }

        private void buttonAVoir_Click(object sender, RoutedEventArgs e)
        {
            ViewModelPersonne vm = (ViewModelPersonne)this.DataContext;
        }
    }
}
