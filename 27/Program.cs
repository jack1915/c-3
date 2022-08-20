// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе


Console.Write("Введите число : ");
 
int numbern = Math.Abs(Convert.ToInt32(Console.ReadLine()));

  int SumNum(int numbern){
    
    int counter = Convert.ToString(numbern).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numbern - numbern % 10;
      result = result + (numbern - advance);
      numbern = numbern / 10;
    }
   return result;
  }

int summ = SumNum(numbern);
Console.WriteLine("Сумма цифр в числе: " + summ);