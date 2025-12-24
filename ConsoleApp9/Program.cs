using System;

namespace BASICPRO1
{
    class CAR
    {
        public string Model;
        public int Year;
        public string Color;

        public CAR(string model, int year, string color)
        {
            Model = model;
            Year = year;
            Color = color;
        }
    }

    class MAINCLASS
    {


        static bool Login(string n, string p)
        {



            if ((n == "Ahmad" || n == "Sara" || n == "jad") && p == "1234")
            {
                string welcome = n;

                Console.WriteLine($"Welcome {n}");

                return true;
            }
            else
            {

                Console.WriteLine("Sorry !. there is no user on this info !.PLEASE TRY AGIN! ");
                return false;
            }


        }
        static void Main(string[] args)
        {

            bool k;
            string name;
            do
            {
                Console.WriteLine("Pleas Enter Your UserName to complete:");
                name = Console.ReadLine();
                Console.WriteLine("Enter The Password");
                string pass = Console.ReadLine();

                k = Login(name, pass);
            } while (k == false);


            string x;
            CAR[] cars = new CAR[20];
            int count = 0;

            Console.Clear();
            Console.WriteLine("_____ Welcom to Our Car Sales Shop ! _____\n");
            Console.WriteLine($"___What Do You Want To Do {name}___\n");
            do
            {



                Console.WriteLine(
                    "1.Enter A New Car.\n" +
                    "2.See What We Have On Our Sales Shop.\n" +
                    "3.Exit!.");

                Console.Write(" --> \t");
                int action = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (action == 1)
                {
                    do
                    {
                        if (count >= cars.Length)
                        {
                            Console.WriteLine("Car storage is full!");
                            break;
                        }


                        Console.WriteLine("Enter the Car Model :");
                        string mod = Console.ReadLine();
                        Console.WriteLine("Enter the Car Year Manufacture :");
                        int man = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Car Color :");
                        string col = Console.ReadLine();


                        cars[count] = new CAR(mod, man, col);
                        count++;




                        Console.WriteLine("Do you want to add other car ? (yes,no)");
                        x = Console.ReadLine();

                        Console.WriteLine("\n__________________\n");

                    } while (x.ToLower() == "yes");
                }
                else if (action == 2)
                {

                    if (count == 0)
                    {
                        Console.WriteLine("You have Nothing Here To See");
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine(cars[i].Model);
                            Console.WriteLine(cars[i].Year);
                            Console.WriteLine(cars[i].Color);
                            Console.WriteLine("_______________\n");

                        }
                    }


                }
                else if (action == 3)
                {
                    Console.WriteLine($"See You Soon {name}");
                    break;

                }

            } while (true);


        }
    }
}