void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
      Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

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

Console.Write("Введите число элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray);

int result = EvenNumberCount(myArray);
Console.WriteLine("Количество чётных элементов массива: " + result);
*/


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

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int result = SumOfElementsOnOddIndex(myArray);
Console.WriteLine("The sum of elements on odd indexes is " + result);






