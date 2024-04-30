////Домашнее задание. Тема 12. Урок 1. Операторы
////ветвления Switch/ Case.
////Калькулятор: пользователь может выбрать операцию (сложение,
////вычитание, умножение, деление), ввести два числа и получить результат


Random random = new Random();

Console.Write("Введите первое число:");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int m = int.Parse(Console.ReadLine());
switch (n)
{

    case 1:
        {
            Console.Write("Введите Ответ:");
                break;
        }
        case 2:
        {
        Console.Write("Введите второе число:"); break;

        }



}
Console.WriteLine($"сложение  {n+m} || вычитание  {n-m} || умножение  {n*m} || деление {n/m}");