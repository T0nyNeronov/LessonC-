// // Напишите программу, которая принимает на вход число N 
// // и выдает произведение чисел от 1 до N.
// 4->24
// 5->120

Console.WriteLine("Add number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Произведение  "+getsumnum(num));

int getsumnum (int res)
{
    
    int count =1;
    int result = 1;

    while(res>=count)
    {
        result*=count; 
        count++;
    }
return result;
} 
