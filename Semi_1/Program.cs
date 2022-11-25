// //  Напишите программу, которая принимает 
// на вход ичсло (А) и выдает сумму чисел от 1 до А

Console.WriteLine("Add number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(getsumnum(num));

int getsumnum (int res)
{
    int sum =0;
    int count =0;

    while(count<res)
    {
        count++;
        sum +=count; 
        
    }
    return sum;
}
