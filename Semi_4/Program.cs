// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Add number");
int num = Convert.ToInt32(Console.ReadLine());

int [] getArray(int size)
{
    int [] array1 = new int[size];

    for (int i = 0; i < size; i++)
    {
        array1[i] = new Random().Next(0,2);
    }
    
    return array1;

}
int [] array1 = getArray(8);

Console.WriteLine(string.Join(",",array1));