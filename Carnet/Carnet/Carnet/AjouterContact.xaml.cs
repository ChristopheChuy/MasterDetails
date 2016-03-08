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
using CarnetLib;
using System.Collections.ObjectModel;
namespace Carnet
{
    /// <summary>
    /// Logique d'interaction pour AjouterContact.xaml
    /// </summary>
    public partial class AjouterContact : Window
    {
        ObservableCollection<Personne> user = new ObservableCollection<Personne>();
        public AjouterContact(ObservableCollection<Personne> users)
        {
            InitializeComponent();
            user = users;
        }

        private void Fermer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Ajouter(object sender, RoutedEventArgs e)
        {
            user.Add(new Personne(AjNom.Text, AjPrenom.Text,""));
            this.Close();
        }
    }
}
