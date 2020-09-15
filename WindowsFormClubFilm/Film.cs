using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormClubFilm
{
    class Film
    {
        private string nom;
        private int annee;
        private string affiche;
        //private bool vu;
        public Film()
        {

        }

        public static List<Film> filmes = new List<Film>();
        public Film(string n, int a,bool v)
        {
            Nom = n;
            Annee = a;
            Vu = v;
        }

        public string Nom { get => Nom; set => Nom = value; }
        public bool Vu { get => Vu; set => Vu = value; }
        public int Annee { get => annee; set => annee = value; }

        public static void ajouter_film(string n,int a ,string aff)
        {
            Film f = new Film();
            f.nom=n;
            f.annee=a;
            f.affiche = aff;
            filmes.Add(f);
        }

        public override string ToString()
        {
            return "Nom :"+nom+"Année:"+annee;
        }

    }
}
