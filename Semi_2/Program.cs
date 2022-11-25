// Напишите программу, которая принимает на вход число
// и выдает количество цифп в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Add number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Количество цифр "+getsumnum(num));

int getsumnum (int res)
{
    if(res<0){
        res = - res;
    }
    int count =0;

    while(res>0)
    {
        count++;
        res/=10; 
        
    }
return count;
}
