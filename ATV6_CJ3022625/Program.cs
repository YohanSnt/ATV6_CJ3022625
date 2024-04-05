namespace ATV6_CJ3022625
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n<<EX.1>>");
            int n, c = 0;

            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());
            while (c < n)
            {
                c++;
                Console.WriteLine(c);

            }


            Console.WriteLine("\n<<EX.2>>");
            int nm, p = 0;
            Console.WriteLine("Digite um número: ");
            nm = int.Parse(Console.ReadLine());

            while (p <= nm)
            {
                p++;
                if (p % 2 == 0)
                {
                    Console.WriteLine(p);
                }

            }





            Console.WriteLine("\n<<EX.3>>");
            int num, d = 1000;
            Console.WriteLine("Digite um número menor que 1000: ");
            num = int.Parse(Console.ReadLine());

            while (d >= num)
            {
                d--;
                if (d % 2 == 0)
                {
                    Console.WriteLine(d);
                }

            }


            Console.WriteLine("<<EX.4>>");
            int ps; int ww = 0;
            while (ww < 200)
            {
                Console.WriteLine("Digite uma sequência de números inteiros: ");
                ps = int.Parse(Console.ReadLine());

                if (ps > 0)
                {
                    ww += ps;
                }

                Console.WriteLine(ww);
            }


            Console.WriteLine("\n<<EX.5>>");
            int a, dv = 1;
            Console.WriteLine("Digite um número: ");
            a = int.Parse(Console.ReadLine());

            while (dv <= a)
            {
                dv++;
                if (a % dv == 0)
                {
                    Console.WriteLine(dv);
                }

            }
        }
    }
}
    
       
