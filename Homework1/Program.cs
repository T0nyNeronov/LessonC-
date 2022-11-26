// // Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// // 3, 5 -> 243 (3⁵)

// // 2, 4 -> 16


// Console.WriteLine("Add number one");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Add number two");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Итоговый результат = " + Math.Pow(num1, num2));


Console.WriteLine("Add number one");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add number two");
int num2 = Convert.ToInt32(Console.ReadLine());

int GetNumCube(int res)
{
    int result=1;
for (int i = 1; i <= num2; i++)
{
result=result *num1;
  
}
return result;
}

Console.WriteLine(num1+" в степени "+num2+" равно "+GetNumCube(num1));
