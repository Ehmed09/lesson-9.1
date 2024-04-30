

//int n;
//do
//{


//Console.WriteLine("Загадываем натуральное число // от 1 до 5"  i++ +" ");


//}
//while (n <= 0) ;
//int i = 1;
//while (i <= 5)
//{
//    Console.Write($"");
//}
//Console.WriteLine(i++ + " ");

////4.Напишите программу, которая запрашивает у пользователя целое
////число и выводит на экран таблицу умножения для этого числа от 1 до
////10. 

int s = 1;
int i = 1;//счетчик чисел
do
{
    Console.Write($"Введите {i} число");
    int a = int.Parse(Console.ReadLine());
    s += a;
    i++;

}
while (i <= 5);
Console.WriteLine(s);
//Ввести число больше нуля