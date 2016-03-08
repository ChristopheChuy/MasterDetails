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
namespace CarnetLib
{
    public class Personne
    {
        public String Name { get; set; }
        public String Prénom { get;  set; }
        public String Image { get;  set; }
        public Dictionary<String, List<String>> Numero { get;  set; }
        public Personne(String nom, String prenom,String chemin)
        {
            Numero = new Dictionary<String, List<String>>();
            Name = nom;
            Prénom = prenom;
            if (chemin.Equals(""))
                Image = "Photos/" + nom + prenom + ".jpg";
            else Image = chemin;
        }

        public override string ToString()
        {
            return Name + " " + Prénom;
        }
    }


}
