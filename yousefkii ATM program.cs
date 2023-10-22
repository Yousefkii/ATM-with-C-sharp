using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        class father
        {
            protected int bankaccount = 123456789;
            protected string accountname = "lord yousefkii";
            protected int passo = 12345;
            public int currentbalance = 5000;
            public int asvingbalance = 20000;

        }
        class withdraw : father
        {
            public int Trans(int num , int accountnumber, string name, int pass)
            {
                if (currentbalance > num || asvingbalance > num && accountnumber == bankaccount && name == accountname && pass == passo)
                {
                    Console.WriteLine("choose 1 if you want to withdraw from your current account and type 2 if want to withdraw from your saving account");
                    int g = int.Parse(Console.ReadLine());
                    switch (g)
                    {
                        case 1:
                            currentbalance -=  num;
                            Console.WriteLine("your current balance = " + currentbalance);
                            break;
                        case 2:
                            asvingbalance -=  num;
                            Console.WriteLine("your saving balance = " + asvingbalance);
                            break;
                        default:
                            break;
                    }
                    return (g);
                }
                else
                {
                    Console.WriteLine("not your account");
                }
                return (asvingbalance);
            }

        }
        class deposittrans : father
        {
            public int transth(int depo, int accountnumber, string name, int pass)
            {
                if (accountnumber == bankaccount && name == accountname && pass == passo)
                {
                    Console.WriteLine("choose 1 if you want to deposit to your current account and type 2 if want to deposit to your saving account");
                    int g = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (g)
                    {
                        case 1:

                            currentbalance += depo;
                            Console.WriteLine();
                            Console.WriteLine("your current balance now = " + currentbalance);
                            break;

                        case 2:

                            asvingbalance += depo;
                            Console.WriteLine();
                            Console.WriteLine("your saving balance now = " + asvingbalance);

                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("not your account");
                }
                return currentbalance;
            }
        }



        static void Main(string[] args)
        {

            //static inputs for now

            Console.WriteLine("enter your bankaccount");
            int accountnumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("enter your accountname");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("enter your pass");
            int pass = int.Parse(Console.ReadLine());
            father pop = new father();

            Console.WriteLine("if u want to withdraw type 1 and if you want to deposit type 2");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (x)
            {
                case 1:

                    Console.WriteLine("enter the number you want to withdraw");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    withdraw withdr = new withdraw();
                    int opp = withdr.Trans(number , accountnumber , name, pass);
                    Console.WriteLine(opp);
                    break;
                    
                case 2:

                    Console.WriteLine("enter the number you want to deposit");
                    int deposit = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    deposittrans deps = new deposittrans();
                    int deep = deps.transth(deposit, accountnumber, name, pass);
                    Console.WriteLine(deep);
                    break;

                default:
                    break;
            }
        }
    }
}
