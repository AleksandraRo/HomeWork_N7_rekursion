Задача 1: 
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.

void WriteDigitsMToN(int M, int N) {
    if (M >=0 && N >=0) { 
 
        if (M == N ) {
            Console.Write(N);
            return;
        }
        if(M <= N) {
            Console.Write(M + " ");
            WriteDigitsMToN(M+1, N);
        } 
        else {
            Console.Write(M + " ");
            WriteDigitsMToN(M-1, N);
        }
    }
    else {
        Console.WriteLine("Введено ненатуральное число.");
    }
}  

WriteDigitsMToN(3,1);

//______________________

//Задача 2
// //Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// // void Main(string[] args)
// // {
//     int m, n;
//    // int [,] Askermann = new int [m,n];        
// //Запрос ввода двух неотрицательных чисел m и n 
//     Console.WriteLine("Введите два неотрицательных числа m и n:");
//     Console.Write("m: ");
//     m = int.Parse(Console.ReadLine());
//     Console.Write("n: ");
//     n = int.Parse(Console.ReadLine());
// // Вычисление и вывод значения функции Аккермана для введенных чисел
//     Console.WriteLine($"Значение функции Аккермана для m={m} и n={n} равно {Ackermann(m, n)}");
// //}

// // // Рекурсивная функция для вычисления функции Аккермана
// int Ackermann(int m, int n)
// {
//     if (m == 0)
// // Если m равно 0, возвращается n + 1
//     {
//         return n + 1;
//     }
//     else 
//     {
//         if (n == 0) 
// // Если n равно 0, вызывается функция Ackermann с параметрами (m - 1, 1)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         else
// // Иначе вызывается функция Ackermann с параметрами (m - 1, Ackermann(m, n - 1))
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }    
//     }
// }

// ______________
// Задача 3: 
// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// // Использовать рекурсию, не использовать циклы.

// int[] array = new int[] { 1, 2, 3, 4, 5 };   

// void PrintArray(int[] array, int index)
// {
//     if (index >= 0)
//     {
//         Console.Write(array[index] + " ");
//         PrintArray(array, index - 1);
//     }
// }
// PrintArray(array, array.Length - 1);

