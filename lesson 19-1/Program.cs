//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//public class Card;

//public class Value;

//public class Mast;

//namespace Focus
//{
//    public class Card
//    {
//        public string Value { get; set; }

//        public string Mast { get; set; }
//    }
//}

//namespace Focus
//{


//    class Program
//    {
//        private static readonly string[] CardValues = { "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
//        private static readonly string[] CardMasts = { "♦", "♥", "♣", "♠" };

//        private static readonly Random Random = new Random();

//        static void Main()
//        {
//            Console.InputEncoding = Encoding.Unicode;
//            Console.OutputEncoding = Encoding.Unicode;

//            while (true)
//            {
//                List<Card> fullDeck = (from cardValue in CardValues
//                                       from cardMast in CardMasts
//                                       select new Card
//                                       {
//                                           Mast = cardMast,
//                                           Value = cardValue
//                                       }).ToList();

//                List<Card> deck = new List<Card>();

//                for (int i = 0; i < 21; i++)
//                {
//                    Card card = fullDeck[Random.Next(0, fullDeck.Count)];
//                    deck.Add(card);
//                    fullDeck.Remove(card);
//                }

//                Console.WriteLine("Запомни любую карту и нажми Enter: ");
//                foreach (Card card in deck)
//                {
//                    Console.Write($"{card.Value}{card.Mast} ");
//                }

//                Console.ReadLine();

//                for (int i = 0; i < 3; i++)
//                {
//                    List<Card> firstDeck = new List<Card>();
//                    List<Card> secondDeck = new List<Card>();
//                    List<Card> thirdDeck = new List<Card>();

//                    for (int j = 0; j < 21; j += 3)
//                    {
//                        firstDeck.Add(deck[j]);
//                        secondDeck.Add(deck[j + 1]);
//                        thirdDeck.Add(deck[j + 2]);
//                    }

//                    Console.WriteLine("\n\nЗдесь есть ваша карта? (da или net\r\n)");
//                    foreach (Card card in firstDeck)
//                    {
//                        Console.Write($"{card.Value}{card.Mast} ");
//                    }

//                    Console.WriteLine();
//                    if (Console.ReadLine()?.ToLower() == "y")
//                    {
//                        deck = secondDeck;
//                        deck.AddRange(firstDeck);
//                        deck.AddRange(thirdDeck);
//                        continue;
//                    }


//                    Console.WriteLine("\n\nЗдесь есть ваша карта? (da или net)");
//                    foreach (Card card in secondDeck)
//                    {
//                        Console.Write($"{card.Value}{card.Mast} ");
//                    }

//                    Console.WriteLine();
//                    if (Console.ReadLine()?.ToLower() == "y")
//                    {
//                        deck = firstDeck;
//                        deck.AddRange(secondDeck);
//                        deck.AddRange(thirdDeck);
//                        continue;
//                    }

//                    deck = firstDeck;
//                    deck.AddRange(thirdDeck);
//                    deck.AddRange(secondDeck);
//                }

//                Console.WriteLine("\nВаша карта: " + deck[10].Value + deck[10].Mast);
//                Console.ReadLine();
//            }
//        }
//    }
//}


//int[,] arr = new int[5, 3];
////Инициализация массива значениями:
//// 1. Инициализация массива при объявлении:
//int[,] arr1 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 }, { 11, 12 }, { 13, 14 }, {15,16},{17,18},{19,20} };
//// Тот же массив с заданными размерами:
//int[,] arr2 = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

//// 2. Инициализация массива без указания размерности:
//int[,] arr3 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 }, { 11, 12 }, { 13, 14 }, { 15, 16 }, { 17, 18 }, { 19, 20 } };

//// 3. Инициализация массива после его объявления:
//int[,] ar1;
//arr = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 }, { 11, 12 }, { 13, 14 }, { 15, 16 }, { 17, 18 }, { 19, 20 } };

//// Присваивание значения конкретному элементу массива:
//arr[2, 1] = 25;
////Доступ к элементам массива:
//int[,] arr4 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 }, { 11, 12 }, { 13, 14 }, { 15, 16 }, { 17, 18 }, { 19, 20 } };
//Console.WriteLine(arr1[0, 0]); //1
//Console.WriteLine(arr1[0, 1]); //2
//Console.WriteLine(arr1[1, 0]); //3
//Console.WriteLine(arr1[1, 1]); //4
//Console.WriteLine(arr1[3, 0]); //7
////Получение значения определенного элемента массива и присвоение его переменной:
//int elementValue = arr1[2, 1];
////Получение общего количества элементов (или размерности массива):
//int[,] ar = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 }, { 11, 12 }, { 13, 14 }, { 15, 16 }, { 17, 18 }, { 19, 20 } };
//var arrayLength = arr.Length;
//var total = 1;
//for (int i = 0; i < arr.Rank; i++)
//{
//    total *= arr.GetLength(i);
//}
//Console.WriteLine("{0} равно {1}", arrayLength, total); // равно 20 
////Получение количества строк и столбцов:
//int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 }, { 11, 12 }, { 13, 14 }, { 15, 16 }, { 17, 18 }, { 19, 20 } };
//int r = matrix.GetLength(0); // строки
//int c = matrix.GetLength(1); // столбцы


//////////////////Домашнее задание. Тема 16. Урок 1. Двумерные
//////////////////массивы.
//////////////////1. Создать двумерный массив 3х3. Заполнить его дробными числами от
//////////////////0 до 20.
//////////////////Оформить вывод на экран всех чисел.
//////////////////Добавить возможность замены значения пользователем.
//////////////////Вывод нового массива.
///

//int[,] myArray =
//{
//    {1,2,3, 4,5 },
//    {6,7,8,9,10 },
//    {11,12,13,14,15},
//    {16,17,18,19,20 }
//};
//for (int i = 0; i < myArray.GetLength(0); i++)
//{
//    for (int j = 0; j < myArray.GetLength(1); j++)
//    {
//        Console.Write(myArray[i, j]+" ");
//    }
//    Console.WriteLine();
//}


//////2.Создать массив символов 5х2.
//////Заполнить его символами по желанию в разнобой.
//////Вывести на экран понятное слово.
int[,] myArray = 
{
    {1,2,3, 4,5 },
    {6,7,8,9,10 },
    {11,12,13,14,15},
    {16,17,18,19,20 }
};
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        Console.Write(myArray[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(myArray.Length);
Console.WriteLine(myArray.GetUpperBound(0) + 1);
Console.WriteLine(myArray.GetUpperBound(1) + 1);