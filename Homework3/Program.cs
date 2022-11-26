// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Add number");
int num = Convert.ToInt32(Console.ReadLine());

int [] getArray(int size)
{
    int [] array1 = new int[size];

    for (int i = 0; i < size; i++)
    {
        array1[i] = new Random().Next(0,100);
    }
    
    return array1;

}
int [] array1 = getArray(8);

Console.WriteLine(string.Join(",",array1));