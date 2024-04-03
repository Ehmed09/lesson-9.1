//1.Произведите операцию логического умножения со следующими
//числами:

int firstOper = 8;
int secondOper = 3;
Console.WriteLine(firstOper & secondOper);
Console.WriteLine(22 & 4);

//2.Произведите операцию логического сложения со следующими
//числами:

Console.WriteLine(65 | 29);
Console.WriteLine(44 | 12);

//3.Произведите операцию логического исключения со
//следующими числами, разберитесь с возможностью шифрования
//чисел

Console.WriteLine(249 ^ 8);

Console.Write("Ввидите число:");
int n = int.Parse(Console.ReadLine());
Console.Write("Ввидите ключ:");
int key = int.Parse(Console.ReadLine());
int crypt = n ^ key;
Console.WriteLine($"Зашифрованное сообщение:{crypt}");
int encrypt = crypt ^ key;
Console.WriteLine($"Зашифрованное сообщение:{encrypt}");