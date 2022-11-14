// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 1000);
    Console.Write(array[i] + " ");
}

double DifferenceMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }

        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double difference = max - min;
    return difference;
}

Console.WriteLine("Разница между максимальным и минимальным элементом массива = " + DifferenceMaxMin(array));