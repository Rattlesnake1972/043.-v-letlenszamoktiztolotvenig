using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043.veletlenszamoktiztolotvenig
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 10; i < 50; i++)     // Ez a sor 40 db random számot fog kiírni, mert a 10 és az 50 közti intervallumot veszi.
            {
                Console.WriteLine(random.Next(10, 50));   // Ha a zárójelbe nem írunk paramétereket, akkor az integer (int) vagyis 2 milliárdig generálja a véletlen   számokat, de a for ciklusban megadott paraméterek miatt akkor is csak 40 db számot fog kiírni. Viszont nekünk nem kellenek ekkora számok, mert a feladat azt mondja, hogy 10-től 50-ig generáljon számokat, így ide is be kell írni a kért paramétereket.
            }

            //int num = random.Next(1, 7);     // 1-től 7-ig egész számokat generál

            //double num = random.NextDouble();   //tizedes törteket generál

            //Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
