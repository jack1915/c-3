// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе


Console.Write("Введите число : "); 
int numbern = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int sum=0;
for (int i=10; i>=0; i--)
{
    sum+=numbern/(int)Math.Pow(10.0,i);
    numbern=numbern%(int)Math.Pow(10.0,i);
}
Console.WriteLine("Сумма цифр в числе:" + sum);