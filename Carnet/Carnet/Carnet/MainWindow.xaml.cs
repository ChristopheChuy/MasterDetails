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
using CarnetLib;
using System.Collections.ObjectModel;
using System.IO;
namespace Carnet
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String chemin = System.AppDomain.CurrentDomain.BaseDirectory+"../../data.txt";
        private ObservableCollection<Personne> users = new ObservableCollection<Personne>();
        public MainWindow()
        {
            InitializeComponent();
            charger();
            laListe.ItemsSource = users;
        }

        private void AjouterContact(object sender, RoutedEventArgs e)
        {
            AjouterContact aj = new AjouterContact(users);
            aj.Show();
        }

        private void ChangerInfo(object sender, SelectionChangedEventArgs e)
        {
            changerinformation();

        }
        private void changerinformation()
        {
            if (laListe.SelectedItem != null)
            {
                ImageP.Source = new BitmapImage(new Uri((laListe.SelectedItem as Personne).Image, UriKind.RelativeOrAbsolute));
                BlockNom.Text = (laListe.SelectedItem as Personne).Name;
                BlockPrenom.Text = (laListe.SelectedItem as Personne).Prénom;
                AfficherNumero(laListe.SelectedItem as Personne);
            }
            else
            {
                BlockNom.Text = null;
                BlockPrenom.Text = null;
                ImageP.Source = null;
            }

        }
        private void AjouterNumero(object sender, RoutedEventArgs e)
        {
            AjouterNumero aj = new AjouterNumero(laListe.SelectedItem as Personne, listeNum);
            aj.Show();
        }

        public void AfficherNumero(Personne p)
        {
            listeNum.Children.Clear();
            foreach (String element in p.Numero.Keys)
            {
                List<String> li = new List<String>();
                p.Numero.TryGetValue(element, out li);
                foreach (String num in li)
                {
                    TextBlock t = new TextBlock();
                    t.Text = element + " | " + num;
                    listeNum.Children.Add(t);
                }
            }
        }

        private void Actualiser(object sender, RoutedEventArgs e)
        {
            AfficherNumero(laListe.SelectedItem as Personne);
        }

        private void Nouveau(object sender, RoutedEventArgs e)
        {
            users = new ObservableCollection<Personne>();
            laListe.ItemsSource = users;
            changerinformation();
            listeNum.Children.Clear();
        }

        private void sauvegarde(object sender, RoutedEventArgs e)
        {
            Sauver(); 

        }
        private void Sauver(){
             using (StreamWriter sw = new StreamWriter(chemin))
            {
                foreach (Personne personne in users)
                {
                    sw.WriteLine(personne.Name);
                    sw.WriteLine(personne.Prénom);
                    if(personne.Image.Equals("Photos/" + personne.Name + personne.Prénom + ".jpg"))
                        sw.WriteLine((String)null);
                    else sw.WriteLine(personne.Image);
                    sw.WriteLine(personne.Numero.Keys.Count);
                    foreach (String type in personne.Numero.Keys)
                    {
                        sw.WriteLine(type);
                        List<String> li = new List<String>();
                        personne.Numero.TryGetValue(type, out li);
                        sw.WriteLine(li.Count);
                        foreach (String num in li)
                        {
                            sw.WriteLine(num);
                        }
                    }

                }
            }
        }
        private void charger()
        {
            String[] types={"Domicile","Professionnel","Mobile","Fax"};
            String Nom;
            using (StreamReader sr = new StreamReader(chemin))
            {
                while ((Nom = sr.ReadLine()) != null)
                {
                    String Prenom = sr.ReadLine();
                    String Chemin =sr.ReadLine();
                    Personne pers = new Personne(Nom, Prenom,Chemin);
                    for (int i = Convert.ToInt32(sr.ReadLine()); i > 0; i--)
                    {
                        String type = sr.ReadLine();
                        List<String> listNum = new List<String>();
                        int nb = Convert.ToInt32(sr.ReadLine());
                        for (int j = 0; j < nb; j++)
                        {
                            listNum.Add(sr.ReadLine());

                        }
                        pers.Numero.Add(type, listNum);
                    }
                    users.Add(pers);
                }
            }

        }

        private void SuprimerNum(object sender, RoutedEventArgs e)
        {
            SurprimerNumero sup = new SurprimerNumero(laListe.SelectedItem as Personne,listeNum);
            sup.Show();
        }

        private void fermer(object sender, EventArgs e)
        {
            Sauver();
            this.Close();
        }

        private void SupprimerPersonne(object sender, RoutedEventArgs e)
        {
            users.Remove(laListe.SelectedItem as Personne);
        }

        private void Modifier(object sender, RoutedEventArgs e)
        {
            Modifier mo = new Modifier(laListe.SelectedItem as Personne,users);
            mo.Show();
        }

    }
}
