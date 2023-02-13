// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


int[] numbers = new int[123];
int chek=0;


for (int i = 0; i < numbers.Length; i++)
{
    numbers[i]= new Random().Next(0,1000);
    Console.Write($" {numbers[i]} \t");
}
for (int i = 0; i < numbers.Length; i++)
{ if ((numbers[i]>9)&&(numbers[i]<100))
    chek++;
}
Console.WriteLine();
Console.Write($"Количество чисел в отрезке {chek}");