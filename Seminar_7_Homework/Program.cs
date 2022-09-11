// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// double[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     double[,] array = new double[rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<cols; j++)
//             array[i,j] = Convert.ToDouble(new Random().Next(min*10, max*10+1)/10.0);
//     return array;
// }

// void Show2dArray(double[,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ "\t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);



// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<cols; j++)
//             array[i,j] = new Random().Next(min, max+1);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// void ElementOfArray(int i, int j, int[,] array){
//     if (i > array.GetLength(0) - 1 || j > array.GetLength(1) - 1) Console.WriteLine("Элемента с введеннным индексом не существует");
//     else Console.Write(array[i, j]);
// }

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);

// Console.Write("Input i: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input j: ");
// int j = Convert.ToInt32(Console.ReadLine());
// ElementOfArray(i, j, array);

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
    int[,] array = new int[rows,cols];
    for(int i = 0; i<rows; i++)
        for(int j = 0; j<cols; j++)
            array[i,j] = new Random().Next(min, max+1);
    return array;
}

void Show2dArray(int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

double[] ArithmeticMean(int[,] array){
    double[] resultArray = new double[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(1); i++){
        for (int j = 0; j < array.GetLength(0); j++){
            resultArray[i] += array[j,i];
        }
        resultArray[i] = resultArray[i] / array.GetLength(0);
    }
    return resultArray;
}

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows,cols,min,max);
Show2dArray(array);

double[] resultArray = ArithmeticMean(array);
Console.Write("Cреднее арифметическое элементов в каждом столбце: ");
for (int i= 0; i < resultArray.GetLength(0); i++) {
    Console.Write(resultArray[i]+ "; ");
}

