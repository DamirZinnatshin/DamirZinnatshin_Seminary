// // Типы данных
// // int - целое число
int x = 6;
// // int abc;
// // double - дробное число
// // double y = 2.5;
// // string - строка
// // string str = "Привет всем!)";
// // bool - логический тип данных. Может принимать значения true (истина) или false (ложь)
// // bool b = y > x; // 2.5 > 5 == false

// // Блоки кода
// // Пространство между двумя фигурными скобками называется блок кода
// {
// }

// // Ветвление if..else
// // if (x == 5) // == - проверка на равенство
// // если выражение в скобках верное, то выполняется этот блок кода
// // {
// //    Console.WriteLine("x это пять");
// //}
 // //else 
// // если выражение не верное, то выполняется блок кода после else
// //{
// //    Console.WriteLine("x это НЕ пять");
// // }

// // Цикл
// int a = 0;
// while (a < 5)
// // // если условие в скобках верное, то выполняется этот блок кода
// {
//      Console.WriteLine(a);
//      a++; // увеличение a на единицу
// //     // равнозначно с:
// //     // a = a + 1;
// //     // a += 1;
// }


// // Написать программу: программа получает число с консоли, 
// // возводит его в квадрат и выводит на экран

// // Console.WriteLine -- вывод сообщения в консоль
// Console.WriteLine("Привет! Введите число, чтобы мы возвели его в квадрат");
// // Console.ReadLine -- получаем текст с консоли
// string str = Console.ReadLine();

// // int.Parse -- переводит строку (string) в число (int)
// int number = int.Parse(str);

// // * -- умножение
// int square = number * number;

// Console.WriteLine("Квадрат вашего числа " + square);

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите число");
// string text = Console.ReadLine();
// Console.WriteLine(); // пустая строка для разделения
// int number = int.Parse(text); // например, 2
// int negativeNumber = number * -1; // 2 * -1 == -2
// while (negativeNumber <= number) // -2 <= 2 == true
// {
//     Console.WriteLine(negativeNumber); // выводим -2
//     // -2 + 1 == -1
//     negativeNumber++; // увеличение negativeNumber на единицу
//     // равнозначно с:
//     // negativeNumber = negativeNumber + 1;
//     // negativeNumber += 1;
// }

// int num = -5;
// int absNum = Math.Abs(num); // Модуль числа 
// Console.WriteLine(absNum);

// Вычислить квадрат числа
// Console.WriteLine ("Введите число, чтобы мы возвели его в квадрат");
// string str = Console.ReadLine();
// int number = int.Parse (str);
// int square = number * number;
// Console.WriteLine ("Квадрат вашего числа: " + square);

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// Console.WriteLine ("Введите исходное число");
// string text = Console.ReadLine();
// Console.WriteLine ();
// int number = int.Parse (text);
// int negative_number = -1 * number;
// while (negative_number <= number)
// {
//     Console.WriteLine (negative_number);
//     negative_number++;
// }

// Напишите программу, которая принимает на вход два числа и проверяет, является ли первое число квадратом второго
// Console.WriteLine ("Введите первое число");
// string str1 = Console.ReadLine();
// Console.WriteLine ("Введите второе число");
// string str2 = Console.ReadLine();
// int A = int.Parse(str1);
// int B = int.Parse(str2);
// if (A/B == B)
// {
//     Console.WriteLine ("Первое число является квадратом второго");
// }
// else
// {
//     Console.WriteLine ("Первое число НЕ является квадратом второго");
// }

