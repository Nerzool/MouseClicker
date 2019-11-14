using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mouseclicker
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculAllerRetoursDeBricabracVersWham();

            //RobotclickMaison();


            Console.ReadKey();
        }

        private static void RobotclickMaison()
        {
            //affichage de la position de la souris
            //var pos = MouseOperations.GetCursorPosition();
            //Console.WriteLine($"X: {pos.X} - Y: {pos.Y}");
            //Console.ReadKey();

            //synchro off
            Console.ReadKey();
            MouseOperations.DoMouseClick(145, 15);
            MouseOperations.DoMouseClick(1375, 475);
            MouseOperations.DoMouseClick(345, 15);
            MouseOperations.DoMouseClick(1375, 475);
            MouseOperations.DoMouseClick(545, 15);
            MouseOperations.DoMouseClick(1375, 475);
            MouseOperations.DoMouseClick(745, 15);
            MouseOperations.DoMouseClick(1375, 475);
        }

        private static void CalculAllerRetoursDeBricabracVersWham()
        {
            DateTime premiereAttaque = new DateTime(2019, 11, 14, 17, 49, 41);

            TimeSpan aller = new TimeSpan(01, 22, 28);

            var retour = premiereAttaque + aller;

            TimeSpan allerRetour = new TimeSpan(2, 44, 56);

            var deuxiemeAttaque = premiereAttaque + allerRetour;

            Console.WriteLine(retour);
            Console.WriteLine(deuxiemeAttaque.ToString());
        }
    }
}
