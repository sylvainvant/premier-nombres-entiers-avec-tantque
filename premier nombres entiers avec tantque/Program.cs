using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace premier_nombres_entiers_avec_tantque
{
    class Program
    {
        static void Main(string[] args)
        {
//declaration variable
double n;
string saissie;
double resultat = 0;
double cpt = 1;
    Console.WriteLine("entrez la valeur n a calculer:");
    saissie = Console.ReadLine();
    n = Convert.ToDouble(saissie);
       while(cpt<=n)
          {
            resultat = resultat + cpt;
            cpt = cpt + 1;
          }
       Console.WriteLine("Le resultat aver pour est:" + resultat);
       // permet de conserver affichage consol
       Console.ReadLine();
        }
    }
}
