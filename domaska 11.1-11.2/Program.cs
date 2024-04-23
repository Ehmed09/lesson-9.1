
//1.Сгенерировать случайное целое число в диапазоне от 0 до 5, запросить
//еще одно число у пользователя и в случае совпадения вывести на экран
//информацию о победе, в противном случае - поражении.

////Создание объекта для генерации чисел
//Random random = new Random();

////Получить случайное число (в диапазоне от 0 до 5)
//int s = random.Next(0, 5);
////Вывод числа в консоль

//Console.WriteLine(s);


//2.Запросить у пользователя порядковый номер текущего месяца и
//вывести его название.

//Console.Write("Введите название месяц ");
//int n = int.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1: Console.WriteLine("Зима"); break;
//    case 2: Console.WriteLine("Зима"); break;
//    case 3: Console.WriteLine("Весна"); break;
//    case 4: Console.WriteLine("Весна"); break;
//    case 5: Console.WriteLine("Весна"); break;
//    case 6: Console.WriteLine("Лето"); break;
//    case 7: Console.WriteLine("Лето"); break;
//    case 8: Console.WriteLine("Лето"); break;
//    case 9: Console.WriteLine("Осень"); break;
//    case 10: Console.WriteLine("Осень"); break;
//    case 11: Console.WriteLine("Осень"); break;
//    case 12: Console.WriteLine("Зима"); break;
//    default: Console.WriteLine(""); break;
//}


//Напишите программу на C#, которая запрашивает у пользователя его
//возраст и выводит сообщение о том, можно ли ему участвовать в
//выборах президента.
//Кандидаты в президенты солнечного города:
//● Незнайка
//● Лунтик
//● Карлсон
//● Дядя Фёдор
//После ввода возраста, задать пользователю вопрос, за кого он будет
//болеть, если проиграет или не будет допущен к участию в выборах.
//В зависимости от выбора пользователя вывести на экран культовую
//фразу персонажа.
//Например:
//Незнайка: “А у тебя в животе арбуз вырастет!!!”.
//Если возраст меньше 18 лет, то выводится сообщение "Вы слишком
//молоды для участия в выборах".
//Если возраст от 18 до 35 лет включительно, то выводится сообщение "Вы
//можете участвовать в выборах в качестве депутата".
//Если возраст от 36 до 65 лет включительно, то выводится сообщение "Вы
//можете участвовать в выборах в качестве кандидата в президенты".
//Если возраст больше 65 лет, то выводится сообщение "Ваш возраст
//слишком велик для участия в выборах".
//Дополнительные задания на 10ку:
//Console.Write("Введите ваш возрaст");
//int age = int.Parse(Console.ReadLine());
//if (age < 18) Console.WriteLine("Вы слишкоммолоды для участия в выборах");
//else if (age >= 18 && age <= 35) Console.WriteLine("Вы можете участвовать в выборах в качестве прецзидента");
//else Console.WriteLine("ваш возрост слишком велик для учатия в выборах");
//Console.WriteLine("Кандидаты в президенты солнечного города:\r\n● Незнайка●\r\nЛунтик●\r\n Карлсон●\r\n Дядя\r\n Фёдор");
//Console.Write("за кого бы вы голосовали:");
//string name = Console.ReadLine();
//if (name == "незнайка") Console.WriteLine("А у тебя животе арбуз вырастет|||");


//int s = 0;
//Console.Write("Введите 1 число");
//int a1 = int.Parse(Console.ReadLine());
//s += a1;
//Console.Write("Введите 2 число");
//int a2 = int.Parse(Console.ReadLine());
//s += a2;
//Console.Write("Введите 4 число");
//int a4 = int.Parse(Console.ReadLine());
//s += a4;
//Console.Write("Введите 5 число");
//int a5 = int.Parse(Console.ReadLine());
//s += a5;
//Console.WriteLine(s);

//int s1 = 0;
//Console.Write("Введите 3 число");
//int a3 = int.Parse(Console.ReadLine());
//s += a3;
//int i = 1;//счетчик чисел
//while (i <= 5)
//{
//    Console.Write($"Введите {i} число");
//    int a = int.Parse(Console.ReadLine());
//    s += a;
//    i++;

//}
//Console.WriteLine(s);



//Console.Write("Введите месяц ");
//int n = int.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1: Console.WriteLine("Январь"); break;
//    case 2: Console.WriteLine("Февраль"); break;
//    case 3: Console.WriteLine("март"); break;
//    case 4: Console.WriteLine("Апрель"); break;
//    case 5: Console.WriteLine("Май"); break;
//    case 6: Console.WriteLine("Июнь"); break;
//    case 7: Console.WriteLine("Июль"); break;
//    case 8: Console.WriteLine("Август"); break;
//    case 9: Console.WriteLine("Сентябрь"); break;
//    case 10: Console.WriteLine("октябры"); break;
//    case 11: Console.WriteLine("Ноябры"); break;
//    case 12: Console.WriteLine("Декабры"); break;
//    default:
//        Console.WriteLine("Нет такого месяца, ты пьян, иди домой:)"); break;



//1.Напишите программу, которая генерирует случайный месяц
//(например, январь, февраль или март) и запрашивает у
//пользователя угадать, сколько дней в этом месяце. Если
//пользователь угадывает правильно, программа выводит сообщение
//о победе. Если нет, программа выводит сообщение о том, сколько
//дней было в месяце
//Random random = new Random();
//int n = random.Next(13);
//switch (n)
//{
//    case 1:
//        {
//            Console.WriteLine("Январь");
//        }
//        break;

//    case 2:
//        {
//            Console.WriteLine("Февраль");
//        }
//        break;
//    case 3:
//        {
//            Console.WriteLine("март");
//        }
//        break;

//    case 4:
//        {
//            Console.WriteLine("Апрель");
//        }
//        break;
//}
//Console.WriteLine("Введите количество дней");
//int m = int.Parse(Console.ReadLine());
//if (n == 1 || n == 3 || n == 5 || n == 7 || n == 8 || n == 9 || n == 10 || n == 12)
//    if (m == 31) Console.WriteLine("Победа");
//    else Console.WriteLine($"Поражение ! в этом месяце 31 дунь");
//else if (n == 4 || n == 6 || n == 9 || n == 11)
//    if (m == 30) Console.WriteLine("Победа");
//    else if (n == 2 && (m == 29)) Console.WriteLine();