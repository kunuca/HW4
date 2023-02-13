// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Write("Введите размер массива ");
int l=int.Parse(Console.ReadLine()!);

int[] numbers = new int[l];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i]= new Random().Next(0,100);
    Console.Write($" {numbers[i]} \t");
}
int max=numbers[0];
int min=numbers[0];
for (int i = 0; i <numbers.Length; i++) 

{   if (max<numbers[i]) max=numbers[i];
    else 
    {if (min>numbers[i]) min=numbers[i];}

}
Console.WriteLine($"\n Разница между максимальным и мимальным числом равна {max-min}");