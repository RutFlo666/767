namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Millist kojundit soovid?:");
            Console.Write("\n\n");

            string figure = Console.ReadLine();

            if (figure == "ruut")
            {
                Square();
            }
            else if (figure == "teemant")
            {
                teemant();
            }
            else if (figure == "ristkylik")
            {
                Square2();
            }
            else if (figure == "kolmnurk")
            {
                Square3();
            }
           

        }

        static void Square3()
        {
            Console.WriteLine("");
            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }


                Console.Write("\n");
            }


        }




        static void Square2()
        {
            Console.WriteLine("Sisesta ruudu suurus");
            int size = int.Parse(Console.ReadLine());

            for (int row = 3; row <= size; row++)
            {
                for (int column = 1; column <= size; column++)
                {
                    string mark;
                    if (row == column || row + column <= size + 1)
                    {
                        mark = "* ";
                    }
                    else
                    {
                        mark = "* ";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }


        }


        static void Square()
        {
            Console.WriteLine("Sisesta ruudu suurus");
            int size = int.Parse(Console.ReadLine());

            for (int row = 1; row <= size; row++)
            {
                for (int column = 1; column <= size; column++)
                {
                    string mark;
                    if (row == column || row + column <= size + 1)
                    {
                        mark = "* ";
                    }
                    else
                    {
                        mark = "* ";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }


        }








        static void teemant()
        {
            

            double radius;
            double thickness = 0.4;
            char symbol = '*';


            do
            {

                if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                {
                    Console.WriteLine("Radius have to be positive number");
                }

            }
            while (radius <= 0);


            Console.WriteLine();
            double rIn = radius - thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.6 )
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }



        }

    

    }

    
}
