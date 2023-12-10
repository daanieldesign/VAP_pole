using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAP_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Deklarace pole
            1.Deklarujte pole čísel
            2.Deklarujte pole řetězců
            3.Deklarujte prázdné pole s datovým typem char
            4.Naplňte pole až po jeho deklaraci
            5.Nechte uživatele vybrat velikost pole při deklaraci*/

            //1.
            int[] pole = { 1, 2, 3, 4, 5 };
            //2.
            string[] pole2 = { "Klavesnice", "Myš", "Auto" };
            //3.
            char[] pole3 = { };
            //4.
            int[] pole4 = new int[5];
            pole4[0] = 0;
            pole4[1] = 1;
            pole4[2] = 2;
            pole4[3] = 3;
            pole4[4] = 4;
            pole4[5] = 5;
            //5.
            int velikost = Convert.ToInt16(Console.ReadLine());
            int[] pole5 = new int[velikost];

            /*Přistupování k indexům
            1.Vypište hodnotu prvků na náhodných indexech
            2.Vypište hodnotu prvního prvku
            3.Vypište hodnotu posledního prvku
            4.Nechte uživatele vybrat, který prvek vypíše
            5.Vypište jednotlivé prvky v poli*/

            //1.
            int[] pole6 = { 1, 2, 3 };
            Console.WriteLine(pole6[1]);
            Console.WriteLine(pole6[2]);
            //2.
            Console.WriteLine(pole6[0]);
            //3.
            Console.WriteLine(pole[pole.Length - 1]);
            //4.
            int index = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(pole6[index]);
            //5.
            for (int i = 0; i < pole6.Length; i++)
            {
                Console.WriteLine(pole6[i]);
            }

            /*Manipulace s polem
            1. Zkopírujte hodnoty z jednoho pole do druhého
            2. Seřaďte prvky v poli
            3. Zjistěte průměr všech hodnot v poli
            4. Převeďte pole na string
            5. Spočítejte všechny duplikáty hodnot v poli
            6. Převeďte string na pole charů
            7. Vypište prvky pozpátku
            8. Vypište každý druhý prvek
            9. Sečtěte všechny prvky v poli*/

            //1.
            int[] pole7 = { 1, 2, 3 };
            int[] pole8 = new int[pole7.Length];

            for (int i = 0; i < pole7.Length; i++)
            {
                pole8[i] = pole7[i];
            }
            //2.
            int[] pole9 = { 3, 2, 1 };

            Array.Sort(pole9);

            for (int i = 0; i < pole9.Length; i++)
            {
                Console.WriteLine(pole9[i]);
            }
            //3.
            int[] pole10 = { 1, 2, 5 };

            double prumer = Array.Average(pole10);

            Console.WriteLine(prumer);
            //4.
            int[] pole11 = { 1, 2, 3 };

            string retezec = string.Join(" ", pole11);

            Console.WriteLine(retezec);
            //5.
            int[] pole12 = { 1, 4, 8, 4, 8, 4 };

            int pocet = 0;

            for (int i = 0; i < pole12.Length; i++)
            {
                if (pole12[i] == pole12[i + 1])
                {
                    pocet++;
                }
            }

            Console.WriteLine(pocet);
            //6.
            string poleRetezec = "Auto";

            char[] pole13 = new char[poleRetezec.Length];

            for (int i = 0; i < poleRetezec.Length; i++)
            {
                pole13[i] = poleRetezec[i];
            }
            //7.
            int[] pole14 = { 1, 2, 3 };

            for (int i = pole14.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(pole14[i]);
            }
            //8.
            int[] pole15 = { 1, 2, 3, 4, 5 };

            for (int i = 1; i < pole15.Length; i += 2)
            {
                Console.WriteLine(pole15[i]);
            }
            //9.
            int[] pole16 = { 1, 2, 3, 4, 5 };

            int suma = 0;

            for (int i = 0; i < pole16.Length; i++)
            {
                suma += pole16[i];
            }
            Console.WriteLine(suma);

            Console.ReadKey();
        }
    }
}
