/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
#region 
int InputLengthArray(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] GetArray(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(99, 1000);
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write( array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int NumberEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count++;
    return count++;
}

int size = InputLengthArray(" Введите длину массива: ");
int[] myArray = GetArray(size);
FillArray(myArray);
PrintArray(myArray);
int numEv = NumberEven(myArray);
Console.WriteLine(" Количество четных чисел: " + numEv);
#endregion
/*
 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
#region 
int InputLengthArr(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] GetArr(int siz)
{
    return new int[siz];
}

void FillArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}

void PrintArr(int[] array)
{
     Console.Write($" Массив: [{string.Join(", " , array)}.]");
     Console.WriteLine();
}

int SumOfOddElements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 1)
            {
                sum += array[i];
            }
    return sum;
}

int siz = InputLengthArr(" Введите длинну массива: ");
int[] myArr = GetArr(siz);
FillArr(myArr);
PrintArr(myArr);
int sumOdd = SumOfOddElements(myArr);
Console.WriteLine(" Сумма не четных элементов: " + sumOdd);
#endregion

/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
#region 
int InputArrNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] ArrayGeneration(int Length)
{
    return new double[Length];
}

void FillingAnArray(double[] array)
{
    
    for(int i = 0; i < array.Length; i++)
        array[i] = Math.Round (new Random().NextDouble() * 10, 1);
}

void ArrayPrint(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
            Console.Write("|");
        else
            Console.Write(".]");
    }
    Console.WriteLine();
}

double MinNumber(double[] array)
{
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i] < min)
            min = array[i];
    return min;
}

double MaxNumber(double[] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i] > max)
            max = array[i];
    return max;
}

int len = InputArrNum(" Введите длинну массива: ");
double[] mArray = ArrayGeneration(len);
FillingAnArray(mArray);
ArrayPrint(mArray);
double minNum = MinNumber(mArray);
double maxNum = MaxNumber(mArray);
double result = maxNum - minNum;
Console.WriteLine(" Разница между числами ровна: " + Math.Round(result, 1));
#endregion