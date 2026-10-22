
//ВЫЗОВЫ
//Задание 1
// PrintHeader("Отчёт");
// PrintHeader("Итоги");


//Задание 2.1
// Console.WriteLine(Max(0,20));
// Console.WriteLine(Max(-10,-30));

//Задание 2.2
// Console.WriteLine(IsEven(4));
// Console.WriteLine(IsEven(7));
// Console.WriteLine(IsEven(0));

//Задание 3
// int[] massiv = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine($"Среднее: {Average(massiv)}");
// Console.WriteLine($"Количество элементов: {CountGreater(massiv, 100)}");

//Задание 4
// double c1 = 0;
// double f1 = ToFahrenheit(c1);
// Console.WriteLine($"{c1} °C = {f1} °F");
// double c2 = 100;
// double f2 = ToFahrenheit(c2);
// Console.WriteLine($"{c2} °C = {f2} °F");
// double c3 = 37;
// double f3 = ToFahrenheit(c3);
// Console.WriteLine($"{c3} °C = {f3} °F");



//Заданиe 5
// Console.WriteLine("Factorial(5) = " + Factorial(5));
// Console.Write("Простые от 2 до 50: ");
// for (int i = 2; i <= 50; i++)
// {
//     if (IsPrime(i) == true)
//     {
//         Console.Write(i + " ");
//     }
// }


//Задание 6
int num1 = ReadPositive("Введите первое число больше 0: ");
int num2 = ReadPositive("Введите второе число больше 0: ");
Console.WriteLine("Сумма: " + (num1 + num2));


//МЕТОДЫ
//Задание 1
//  static void PrintLine()
//  {  
//      Console.WriteLine("^_^");
//  }

// static void PrintHeader(string title)
// {
//     PrintLine();
//     Console.WriteLine(title);
//     PrintLine();
// }

//Задание 2.1
// static int Max(int a,int b)
// {
//     if (a > b)
//     {
//         return a;
//     }
//     else
//     {
//         return b;
//     }
// }


//Задание 2.2
// static bool IsEven(int n)
// {
//     return n % 2 == 0;
// }

//Задание 3
// static double Average(int[] arr) 
//     {
//         int sum = 0;
//         foreach (int i in arr) 
//         {
//             sum+= i;
//         }
//         return (double)sum / arr.Length;
//     }

// static int CountGreater(int[] arr, int limit) 
//     {
//         int count = 0;
//         foreach (int i in arr) 
//         {
//             if (i > limit) 
//             {
//                 count += 1;
//             }
//         }
//         return count;
//     }


//Задание 4
// static double ToFahrenheit(double celsius) 
// {
//     return celsius * 9 / 5 + 32;
// }

//Заданиe 5
//  static long Factorial(int n) 
//     {
//         long result = 1;
//         for (int i = 1; i <= n; i++) 
//         {
//             result *= i;
//         }
//         return result;
//     }

// static bool IsPrime(int n) 
// {
//     if (n < 2) 
//     {
//         return false;
//     }
        
//     for (int i = 2; i < n; i++) 
//     {
//         if (n % i == 0) 
//         {
//             return false;
//         }
//     }
//     return true;
// }


//Задание 6
static int ReadPositive(string message) 
{
    int answer;
    do 
    {
        Console.Write(message);
        answer = Convert.ToInt32(Console.ReadLine());
    } 
    while (answer <= 0);
        
    return answer;
}