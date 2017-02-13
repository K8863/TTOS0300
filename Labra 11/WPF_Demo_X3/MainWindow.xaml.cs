using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using JAMK.ICT;

namespace WPF_Demo_X3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Koska useampi metodi-tapahtumakäsittelijä tulee käyttämään näitä muuttujia -->
        // määritellään luokan tasolle luokan jäsenmuuttujiksi
        JAMK.ICT.HockeyLeague liiga;
        ObservableCollection<JAMK.ICT.HockeyTeam> joukkueet;
        int counter = 0;

        public MainWindow()
        {
            InitializeComponent();
            IniMyStuff();
        }
        private void IniMyStuff()
        {
            // Tänne kootusti omien kontrollien alustukset
            List<string> muuvit = new List<string>();
            muuvit.Add("Halloween");
            muuvit.Add("Jaws");
            muuvit.Add("Star Wars");
            cmbMovies.ItemsSource = muuvit;

            // Haetaan SM-liigajoukkueet
            liiga = new JAMK.ICT.HockeyLeague();       
            joukkueet = liiga.GetTeams();
            cmbTeams.ItemsSource = joukkueet;
        }

        private void btnBind_Click(object sender, RoutedEventArgs e)
        {
            // Määritellään StackPanelin DataContext
            // Demo1: datakontekstini on olio
            //HockeyTeam tiimi = new HockeyTeam("Tappara", "Tampere");
            //spRight.DataContext = tiimi;

            // Demo2: Kytketään olio-kokoelman 1. olioon
            spRight.DataContext = joukkueet[counter];
        }
    }
}
