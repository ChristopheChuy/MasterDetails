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
    /// Logique d'interaction pour Modifier.xaml
    /// </summary>
    public partial class Modifier : Window
    {
        String filename=null;
        Personne personne;
        ObservableCollection<Personne> users;
        public Modifier(Personne p, ObservableCollection<Personne> users)
        {
            InitializeComponent();
            personne=p;
            Nom.Text = p.Name;
            Prenom.Text = p.Prénom;
            this.users=users;


        }

        private void fermer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void modifier(object sender, RoutedEventArgs e)
        {
            String chemin;
            if (filename == null)
                chemin = personne.Image;
            else chemin = filename;
            Personne p = new Personne(Nom.Text, Prenom.Text,chemin);
            p.Numero=personne.Numero;
            users.Remove(personne);
            users.Add(p);
            this.Close();
        }

        private void ChoixPhoto(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";
            dlg.FileName = "Images";
            dlg.DefaultExt = ".jpg | .png | .gif";
            dlg.Filter = "All images files (.jpg, .png, .gif)|*.jpg;*.png;*.gif|JPG files (.jpg)|*.jpg|PNG files (.png)|*.png|GIF files (.gif)|*.gif";
            bool? result = dlg.ShowDialog();
            if (result == true)
            { 
                filename = dlg.FileName;
            }
        }
    }
}
