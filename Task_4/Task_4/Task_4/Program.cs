using System;
using System.Runtime.CompilerServices;

namespace Task_4
{
    public class Money
    {
        private double grivny;
        private int kop;
        double val1;
        double val2;

        public double Grivny
        {
            get
            {
                return grivny;
            }
            set
            {
                if (value > 0)
                {
                    grivny = value;
                }
                else
                {
                    grivny = 0;
                }
            }
        }

        public int Kop
        {
            get
            {
                return kop;
            }
            set
            {
                if (value > 0)
                {
                    kop = value;
                }
                else
                {
                    kop = 0;
                }
            }
        }

        public double Val1
        {
            get
            {
                return val1;
            }
            set
            {
                if (value > 0)
                {
                    val1 = value;
                }
                else
                {
                    val1 = 0;
                }
            }
        }

        public double Val2
        {
            get
            {
                return val2;
            }
            set
            {
                if (value > 0)
                {
                    val2 = value;
                }
                else
                {
                    val2 = 0;
                }
            }
        }

        public void Kopp()
        {
            int _grivny = Convert.ToInt32(grivny);
            kop = _grivny * 100;
            Console.WriteLine("Ваша сума в копійках: "+ kop);
            
        }
        public void Grikopp()
        {
            double _kop = Convert.ToDouble(kop);
            grivny = _kop / 100;
            Console.WriteLine("Ваша сума в гривнях: " + grivny);
        }

        public void Minusplus(double a, double b)
        {
            Console.WriteLine("Якщо хочете додати ці суми натисніть клавішу Q.\nЯкщо хочете отримати різницю цих сум натисніть Y");
            var input = Console.ReadKey();
            Console.WriteLine("\nТепер можете вводити");
            switch (input.Key)
            {
                case ConsoleKey.Y:
                    if (a > b)
                        Console.WriteLine("Різниця сум: " + (a - b));
                    else if (b > a)
                        Console.WriteLine("Різниця сум: " + (b - a));
                    break;
                case ConsoleKey.Q:
                    Console.WriteLine("Сума сум: " + (a + b));
                    break;
            }
        }
  
    }    
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Починаємо\n");
            Money try1 = new Money();
            Console.WriteLine("Якщо хочете ввести гривні, натисніть клавішу Y.\nЯкщо хочете ввести копійки, натисніть клавішу Q.");
            var input = Console.ReadKey();
            Console.WriteLine("\nТепер можете вводити");
            switch (input.Key)
            {
                case ConsoleKey.Y:
                    while (true)
                    {
                        try
                        {
                            string gri = Console.ReadLine();
                            try1.Grivny = Convert.ToDouble(gri);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Щось пішло не так. Введіть ще раз.");
                        }
                    }
                    Console.WriteLine("\nВаша сума (в гривнях): " + try1.Grivny);
                    while (true)
                    {
                        Console.WriteLine("\nХочете перевести у копійки?\n Так - натисніть Enter.\n Ні - натисніть Escape.");
                        var input_1 = Console.ReadKey();
                        switch (input_1.Key)
                        {
                            case ConsoleKey.Enter:
                                try1.Kopp();
                                Console.WriteLine("\nХочете перевести назад у гривні?\nТак - натисніть Enter.\n Ні - натисніть Escape.");
                                var input_2 = Console.ReadKey();
                                switch (input_2.Key)
                                { 
                                    case ConsoleKey.Enter:
                                            try1.Grikopp();
                                            break;
                                    case ConsoleKey.Escape:
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                    break;
                        }
                        break;
                    }
                    break;
                case ConsoleKey.Q:           
                    while (true)
                    {
                        try
                        {
                            string ko = Console.ReadLine();
                            try1.Kop = Convert.ToInt32(ko);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Щось пішло не так. Введіть ще раз.");
                        }
                    }
                    Console.WriteLine("\nВаша сума (в копійках): " + try1.Kop);
                    while (true)
                    {
                        Console.WriteLine("\nХочете перевести у гривні?\n Так - натисніть Enter.\n Ні - натисніть Escape.");
                        var input_1 = Console.ReadKey();
                        switch (input_1.Key)
                        {
                            case ConsoleKey.Enter:
                                try1.Grikopp();
                                Console.WriteLine("\nХочете перевести назад у копійки?\nТак - натисніть Enter.\n Ні - натисніть Escape.");
                                var input_2 = Console.ReadKey();
                                switch (input_2.Key)
                                {
                                    case ConsoleKey.Enter:
                                        try1.Kopp();
                                        break;
                                    case ConsoleKey.Escape:
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                break;
                        }
                        break;
                    } break;
            }


            Console.WriteLine("\nВведіть дві суми для обрахунків (бажано в одному форматі).");
            while (true){
                try
                {
                    string vall = Console.ReadLine();
                    try1.Val1 = Convert.ToDouble(vall);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Щось пішло не так. Введіть ще раз.");
                }
            }
            while (true) {
                try
                {
                    string valll = Console.ReadLine();
                    try1.Val2 = Convert.ToDouble(valll);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Щось пішло не так. Введіть ще раз.");
                }
            }

            try1.Minusplus(try1.Val1, try1.Val2);

            Console.ReadKey();
        }
    }
}
