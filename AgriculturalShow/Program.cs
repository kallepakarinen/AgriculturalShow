using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriculturalShow
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Lipun hinta on ";
            double sum = 0;
            Console.WriteLine("Tervetuloa maatalousnäyttelyyn. ");
            Console.WriteLine("Kerro ikäsi");
            int age = int.Parse(Console.ReadLine());
            if (age < 7)
            {
                message = ("ilmainen sisäänpääsy ");
            }
            else if (age >= 7 && age <= 15 || age >= 65)
            {
                sum = 0.5;
            }
            else
            {
                Console.WriteLine("Oletko Varusmies? 1=Kyllä 2=EI");
                int mil = int.Parse(Console.ReadLine());
                if (mil == 1)
                {
                    sum = 0.5;
                }
                else
                {
                    Console.WriteLine("Oletko Mtk:n jäsen? 1=Kyllä 2=EI");
                    int mtk = int.Parse(Console.ReadLine());
                    Console.WriteLine("Oletko opiskelija? 1=Kyllä 2=EI");
                    int student = int.Parse(Console.ReadLine());
                    if (mtk == 1 && student == 1)
                    {
                        sum = 0.6;
                    }
                    else if (mtk == 1 && student == 2)
                    {
                        sum = 0.85;
                    }
                    else if (mtk == 2 && student == 1)
                    {
                        sum = 0.55;
                    }
                    else
                    {
                        sum = 1;
                    }
                }
            }
            double total = 16 * sum;
            Console.WriteLine(message + total + " Euroa");
            Console.ReadKey();
        }
    }
}
