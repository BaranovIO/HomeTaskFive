/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)   

        array[i] = new Random().Next(100, 1000);  
    
    return array;
}

int EvenNumberCount(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        count++;
    }
    return count;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
      Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите число элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray);

int result = EvenNumberCount(myArray);
Console.WriteLine("Количество чётных элементов массива: " + result);
*/

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)   

        array[i] = new Random().Next(minValue, maxValue + 1);  
    
    return array;
}

int SumOfElementsOnOddIndex(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
       
        sum += array[i];
    
    return sum;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
      Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите число элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int result = SumOfElementsOnOddIndex(myArray);
Console.WriteLine("Сумма элементов массива на нечётных индексах равна " + result);
*/

double[] CreateDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    double[] arrayDouble = new double[size];

    for(int i = 0; i < size; i++)   
    {
        array[i] = new Random().Next(minValue, maxValue);
        arrayDouble[i] = new Random().NextDouble();
        array[i] = array[i] + Math.Round(arrayDouble[i], 2);

    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
      Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double MaxMinusMin(double[] array)
{
    double minNumber = array[0];
    double maxNumber = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < minNumber)
            minNumber = array[i];

        if(array[i] > maxNumber)     
            maxNumber = array[i];
    }
    double dif = maxNumber - minNumber;
    return dif;
}

Console.Write("Введите число элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateDoubleArray(length, min, max);
ShowArray(myArray);

double result = MaxMinusMin(myArray);
Console.WriteLine("Разница между максимальным и минимальным элементами массива равна: " + result);

