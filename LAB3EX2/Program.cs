using System.Security.Cryptography;

namespace lab3ex1
{
    class Program
    {

        /*
         Scrieti un program care va afisa pozitia unui substring intr-un string, ambele
        siruri de caractere fiind citite de la tastatura

         */

        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti sirul de caractere initial: ");
            string primulSir = Console.ReadLine();
            
            Console.WriteLine("Introduceti sirul de caractere pentru care sa afisati index ul");
            string substring = Console.ReadLine();

            Console.WriteLine("Indexul este: "+primulSir.IndexOf(substring));

            /*
             Scrieti un program care sa verifice daca un sir de caractere citit de la tastatura
            este sau nu palindrom
             */

            Console.WriteLine("Vom verifica aici si daca primul sir este palindrom.");
            EstePalindrom(primulSir);
        }

        static bool EstePalindrom(string sirDeNumere)
        {
            string firstHalf = sirDeNumere.Substring(0, sirDeNumere.Length / 2);
            char[] chars = sirDeNumere.ToCharArray();

            Array.Reverse(chars);

            string secondHalf = new string(chars);
            string second = secondHalf.Substring(0, secondHalf.Length / 2);

            if (firstHalf.Equals(second))
            {
                Console.WriteLine("Este Palindrom");
                return true;
            }
            else
            {
                Console.WriteLine("Nu este Palindrom");
                return false;
            }
        }

    }
}