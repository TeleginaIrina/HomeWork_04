// 30. Показать кубы чисел, заканчивающихся на четную цифру;

Console.Clear();
System.Console.WriteLine();

int N = new Random().Next(1, 30);
System.Console.WriteLine($"N = {N}");

// решение через цикл 

int number = 1;
System.Console.WriteLine("By While");
while (number <= N)
{
    int cube = number * number * number;
    if (cube % 2 == 0) System.Console.Write(cube + " ");
    number++;
}
System.Console.WriteLine();


// еще один способ: собрать массив из кубов, а на печать вывести только четные

System.Console.WriteLine("By Method 2");

int[] GetCubeArray(int N)
{
    int i = 0;
    int[] EvenCubs = new int[N];
    for (int num = 1; num <= N; num++)
    {
        EvenCubs[i] = num * num * num;
        i ++;
    }
    return EvenCubs;
}

void PrinEvenCubes(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
PrinEvenCubes(GetCubeArray(N));
System.Console.WriteLine();
