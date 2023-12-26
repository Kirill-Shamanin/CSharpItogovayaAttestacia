// Задача 1: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// int getInt(string str = "")
// {
//     Console.Write(str);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void RoadToN(int N = 2, int M = 1)
// {
//     if(N == M - 1)
//     return;
//     RoadToN(N - 1, M);
//     System.Console.Write($"{N} ");
// }

// int M = getInt("Введите M: ");
// int N = getInt("Введите N: ");

// if(N < M)
// {
//     RoadToN(M, N);
// }
// else
// {
//     RoadToN(N, M);
// }

//---------------------------------------------------------------------------------------------

// Задача 2: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

// int m = getInt("Введите m: ");
// int n = getInt("Введите n: ");

// int FunctionAkkerman = A(m, n);
// System.Console.Write($"Функция Аккермана = {FunctionAkkerman} ");

// int A(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n  == 0) return A(m - 1, 1);
//     else return A(m - 1, A(m, n - 1));
// }

// int getInt(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

//---------------------------------------------------------------------------------------------

// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


int[] CreateArray (int size, int max, int min)
{
    int [] array  = new int[size];
    Random rand = new();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

string PrintArray(int[] array)
{
   return string.Join(", ", array);
}

int[] ArraySwap(int[] array, int index)
{
    if (index <= 0) 
    {
        return array;
    }
int temp = array[index];
array[index] = array[array.Length - index - 1];
array[array.Length - index - 1] = temp;
return ArraySwap(array, index -= 2);
}
int [] array = CreateArray(6, 100, 0);
System.Console.WriteLine($"Массив => [{PrintArray(array)}]");
System.Console.WriteLine($"Перевернутый массив => {PrintArray(ArraySwap(array,array.Length-1))}");
