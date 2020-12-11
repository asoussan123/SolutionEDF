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

namespace ProjetEDF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        edfEntities gst;
        controleur ctrl;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new edfEntities();
            controleur leCtrl = gst.controleur.ToList().Find(ctrl => ctrl.login == txtlogin.Text && ctrl.mdp == txtMdp.Text);
        }
        

        
        
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow frm = new AdminWindow();
            frm.Show();
            //if(txtlogin.Text == "")
            //{
            //    txtErreur.Text = "Saisir le login";
            //}
            //else
            //{
            //    if(txtMdp.Text == "")
            //    {
            //        txtErreur.Text = "Saisir le mdp";
            //    }
            //    else
            //    {
            //        if(txtlogin.Text == ctrl.login && txtMdp.Text == ctrl.mdp)
            //        {
            //            if(ctrl.statut == "admin")
            //            {
            //                AdminWindow frm = new AdminWindow();
            //                frm.Show();
            //            }
            //            else
            //            {
            //                CtrlWindow frm = new CtrlWindow();
            //                frm.Show();
            //            }
            //        }
            //        else
            //        {
            //            txtErreur.Text = "Login ou mdp incorrecte";
            //        }
            //    }
        }
    }
    
}
