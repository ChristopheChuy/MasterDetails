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
namespace Carnet
{
    /// <summary>
    /// Logique d'interaction pour SurprimerNumero.xaml
    /// </summary>
    public partial class SurprimerNumero : Window
    {
        Personne personne;
        List<String> numero;
        StackPanel listNum;
        public SurprimerNumero(Personne p,StackPanel listNum)
        {
            InitializeComponent();
            numero = new List<String>();
            personne = p;
            this.listNum = listNum;
            foreach (String type in personne.Numero.Keys)
            {
                List<String> l;
                personne.Numero.TryGetValue(type, out l);
                foreach (String num in l)
                {
                    numero.Add(num);
                }
            }
            ListeNumero.ItemsSource = numero;
        }

        private void fermer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void suprimer(object sender, RoutedEventArgs e)
        {
            foreach (String types in personne.Numero.Keys)
            {
                List<String> numeros;
                personne.Numero.TryGetValue(types, out numeros);
                numeros.Remove(ListeNumero.SelectedItem as String);
            }
            listNum.Children.Clear();
            foreach (String element in personne.Numero.Keys)
            {
                List<String> lis = new List<String>();
                personne.Numero.TryGetValue(element, out lis);
                foreach (String num in lis)
                {
                    TextBlock t = new TextBlock();
                    t.Text = element + " | " + num;
                    listNum.Children.Add(t);
                }
            }
            this.Close();
        }
    }
}
