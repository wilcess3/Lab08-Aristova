// PrintLine();
// Console.WriteLine("Отчет!");
// PrintLine();

// static void PrintLine()
// {
//     Console.WriteLine("^_^");
// }

//ВЫЗОВЫ
//Задание 1
//  PrintHeader("Отчет");
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


//Задание 2.1
// Console.WriteLine(Max(0,20));
// Console.WriteLine(Max(-10,-30));

//Задание 2.2
// Console.WriteLine(IsEven(4));
// Console.WriteLine(IsEven(7));
// Console.WriteLine(IsEven(0));

//Задание 3 !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
int[] massiv = { 120, 45, 300, 80, 15, 210 };
Console.WriteLine("Среднее: {Average(massiv)}");
Console.WriteLine("Количество элементов: {CountGreater(massiv,100)}");   









//МЕТОДЫ
//Задание 1
// static void PrintLine()
// {  
//     Console.WriteLine("^_^");
// }

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
static double Average(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        summ = summ + arr[i];
    }
    return (double)summ / arr.Length;
}

static int CountGreater(int[] arr, int limit)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > limit)
        {
            count += 1;
        }
    }
}


//Задание 4
static double ToFahrenheit(double celsius)
{
    
}