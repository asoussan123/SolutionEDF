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
using System.Windows.Shapes;

namespace ProjetEDF
{
    /// <summary>
    /// Logique d'interaction pour AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        edfEntities gst;
        int idCont;
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new edfEntities();
            lstControleurs.ItemsSource = gst.controleur.ToList();
        }

        private void lstControleurs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstControleurs.SelectedItem != null)
            {
                idCont = (lstControleurs.SelectedItem as controleur).id;
                lstClients.ItemsSource = (from cl in gst.client
                                         where gst.controleur.Any(i => i.id == cl.identifiant && i.id == idCont)
                                         select cl).ToList<client>();


                int ancien = (lstClients.SelectedItem as client).ancienReleve;
                int dernier = (lstClients.SelectedItem as client).dernierReleve;
                int different = dernier - ancien;

            }
        }
    }
}
