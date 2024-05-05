////Домашнее задание. Тема 14. Урок 1. Цикл For.
////Нужно разработать программу, которая будет генерировать пароли
////заданной длины для пользователей.
////Требования к программе:
////Пользователь должен иметь возможность указать длину пароля при
////запуске программы.
////Пароль должен состоять из букв латинского алфавита (в верхнем и
////нижнем регистре) и цифр.
////Для реализации генерации пароля требуется использовать цикл for.
////Программа должна создавать случайный набор символов, выбирая из
////списка допустимых символов на каждой итерации цикла


//Random random = new Random();
//int n = random.Next(65,90);
//for (int i =0; i < n; i++)
//{

//    {
//        int x = 1;
//        int length;
//        string a = "";
//        object num;


//        while (x == 1)

//        {
//            Console.WriteLine();
//            length = Convert.ToInt32(Console.ReadLine());
//            try
//            {
//                for (int s = 0; i < length; i++)
//                {
//                    int num1 = i;
//                    Int32 ASCII = num1;
//                    num = (char)num1;

//                    if (length > 0)
//                    {
//                        Console.WriteLine(num);
//                    }
//                }
//            }
//            catch
//            {
//                Console.WriteLine(a);
//            }

//            if (length == -1)
//                break;
//        }
//    }
//    Random rondom = new Random();
//    int c, m;    
//}


//class Program
//{
//    static void Main()
//    {
//        Console.Write("Укажите количество квадратов: ");
//        int quantity = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Укажите сторону квадрата: ");
//        int weigth = Convert.ToInt32(Console.ReadLine());

//        for (int i = 0; i < quantity; i++)
//        {
//            for (int j = 0; j < weigth; j++)
//            {
//                Console.Write("*");
//                Console.Write(" ");
//            }
//            Console.WriteLine();
//            for (int k = 0; k < weigth - 2; k++)
//            {
//                Console.Write("*");
//                for (int l = 0; l < weigth + weigth - 2; l++)
//                {
//                    Console.Write(" ");
//                }
//                Console.Write("*");
//                Console.WriteLine();
//            }
//            for (int m = 0; m < weigth; m++)
//            {
//                Console.Write("*");
//                Console.Write(" ");
//            }

//            Console.WriteLine();
//        }
//    }
//}
