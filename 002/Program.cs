// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] numbers = new int[15];
int possitive=0;
int negative=0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i]= new Random().Next(0,1000);
    Console.Write($" {numbers[i]} \t");
}
for (int i = 0; i < numbers.Length; i++)
{ if (numbers[i]%2==0) possitive++;
  else negative++;
}
Console.WriteLine();
Console.WriteLine($"Нечетных чисел в массиве {negative}, четных числе {possitive}");
