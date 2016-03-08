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
    /// Logique d'interaction pour AjouterNumero.xaml
    /// </summary>
    public partial class AjouterNumero : Window
    {
        Personne pers;
        StackPanel listNum;
        List<String> type = new List<String>(){
            "Domicile","Professionnel","Mobile","Fax"
        };
        public AjouterNumero(Personne p,StackPanel listNum)
        {
            InitializeComponent();
            ListeType.ItemsSource = type;
            pers = p;
            this.listNum = listNum;
        }

        private void Fermer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Ajouter(object sender, RoutedEventArgs e)
        {
            List<String> li;
            pers.Numero.TryGetValue(ListeType.SelectedItem as String, out li);
            if (li == null)
            {
                li = new List<String>();
                pers.Numero.Add(ListeType.SelectedItem as String, li);
            }
            li.Add(AjNumero.Text);
            pers.Numero.Remove(ListeType.SelectedItem as String);
            pers.Numero.Add(ListeType.SelectedItem as String, li);
            listNum.Children.Clear();
            foreach (String element in pers.Numero.Keys)
            {
                List<String> lis = new List<String>();
                pers.Numero.TryGetValue(element, out lis);
                foreach (String num in lis)
                {
                    TextBlock t = new TextBlock();
                    t.Text = element + " | " + num;
                    listNum.Children.Add(t);
                }
            }
            this.Fermer(sender, e);

        }

    }
}
