using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using Sgs.Presentation.ViewModel;

namespace Sgs.Presentation.View
{
    /// <summary>
    /// Logique d'interaction pour EtudiantListView.xaml
    /// </summary>
    public partial class EtudiantListView : UserControl
    {
        public EtudiantListView()
        {
            Console.WriteLine("Construtor : Classe EtudiantListView -- Create");

            InitializeComponent();
            DataContext = new EtudiantListViewModel();
        }
    }
}