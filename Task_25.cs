//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите числа a и b: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
 if (b > 0) {
Console.WriteLine($"Ответ: {Math.Pow(a,b)}");
 }else
 {
    Console.WriteLine("Введите натуральную степень числа");
 }
