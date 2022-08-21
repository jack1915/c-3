// Напишите программу, которая задаёт массив из 8
//  элементов и выводит их на экран.

// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] numbers = new int[8];
Random rmd = new Random();
Console.Write( "[");
void Array(int[] array, int min , int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = rmd.Next(-1000, 1000);
  }  
}
void WriteArray(int[] array){
    for (int i = 0; i<7; i++ )   
  {
    Console.Write(array[i] + ", ");
  }
  Console.Write(array[7]);
  Console.Write("]");
  Console.WriteLine();
}
Array(numbers, -1000, 1000);
WriteArray(numbers);
