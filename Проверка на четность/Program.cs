namespace C__урок
{
    internal class chetnoct
    {

        public static bool IsStop(string input)
        {
            return input == "стоп";
        }
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Write("Введите целое число или \"стоп\" чтобы закончить операцию: ");
                string input = Console.ReadLine();
                if (IsStop(input))
                {
                    break;
                }

                if (int.TryParse(input, out int number2))
                {
                    if (number2 % 2 == 0)
                    {
                        Console.WriteLine($"Число: {number2} являеться четным");
                    }
                    else
                    {
                        Console.WriteLine($"Число: {number2} не являеться четным");
                    }
                }
                else
                {
                    Console.WriteLine("Введите коректное число!!");
                }
            }
            
            Console.WriteLine("Программа завершена");


        }
    }
}