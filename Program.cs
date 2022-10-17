// Первое задание
// **Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = GetArray(5,-9,9);
// Console.WriteLine(String.Join(", ",array));
// Console.WriteLine(String.Join(", ",MirrorValueInArray(array)));




//Второе задание
// **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да

// int[] array = GetArray(10,0,9);
// Console.WriteLine(String.Join(", ",array));

// Console.Write("Задайте число: ");
// int findNumber = int.Parse(Console.ReadLine()!);
// Console.WriteLine(FindNumberInArray(array, findNumber));


// Третье задание
/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. От 0 - 1000
*/

// int minValue = 10, maxValue = 99, sizeArray = 123;
// int[] array1 = GetArray(sizeArray, 0, 999);
// ViewArray(array1, " | ", countOnLine: 25, lengthNumber: 3);
// Console.WriteLine($"Кол-во элементов входящих в промежуток от {minValue} до {maxValue} равно - {findCountValue(minValue, maxValue, array1)}");

// int findCountValue (int minValue, int maxValue, int[] collection) {
//     int count = 0;
//     foreach (int x in collection) {
//         if (x >= minValue && x <= maxValue ) count++;
//     }
//     return count;
// }

// Четвертое задание

/*
**Задача 37:** Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21 */
// sizeArray = 5;
// int[] array2 = GetArray(sizeArray, minValue, maxValue);
// Console.WriteLine(String.Join(", ", array2));

// resultArray(array2);

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void resultArray(int[] collection ) {
    for (int i = 0, j = collection.Length-1; i < collection.Length / 2; i++, j--)
    {
        Console.Write(collection[i]*collection[j] + ", ");
    }
    if (collection.Length % 2 != 0)  Console.WriteLine(collection[collection.Length/2]);
}


void ViewArray (int[] collection, String separator, int size = 0, int countOnLine = 0, int lengthNumber = -1){
    Boolean flag = true;
    Boolean isNeedFormat = lengthNumber > 0;
    int temp = countOnLine;
    if (size == 0) size = collection.Length;
    for (int i = 0; i < size; i++)
    {
        flag = true;
        if (isNeedFormat){
            for (int j = 0; j < lengthNumber - collection[i].ToString().Length; j++)
            {
                Console.Write(" ");
            }
        }
        Console.Write(collection[i]);
        if ((countOnLine > 0) && (i == countOnLine - 1)){
            Console.WriteLine();
            countOnLine+=temp;
            flag = false;
        } 
        if (flag) Console.Write(separator);
    }
    if (flag) Console.WriteLine();
}
int[] MirrorValueInArray(int[] collection){
    for (int i = 0; i < collection.Length; i++) collection[i] -= collection[i] * 2;
    return collection;
}

Boolean FindNumberInArray(int[] collection, int findNumber){
    Boolean flag = false;
    foreach (int item in collection)
    {
        if (item == findNumber) {
            flag = true;
            break;
        }
    }
    return flag;
}


// ----------------------------------------------------------------------------------------------------------------
// ДЗ

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] array = GetArray(20,0,999);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine("Четное кол-во чисел = " + EvenNumbers(array));

int EvenNumbers (int[] collection){
    int count = 0;
    foreach (int item in collection)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}

Console.WriteLine();
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


array = GetArray(10, -999, 999);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine("Сумма нечетных чисел = " + SummOddNumbers(array));

int SummOddNumbers (int[] collection){
    int summ = 0;
     foreach (int item in collection)
    {
        if (item % 2 != 0) summ+=item;
    }
    return summ;
}

Console.WriteLine();
// Задача 38: Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


array = GetArray(10,-999999999, 999999999);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine("Разница между максимальным и минимальным элементов массива = " + DifferenceMinMax(array));


int DifferenceMinMax(int[] collection){
    int max;
    int min = max = collection[0]; 
    foreach (int item in collection)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}