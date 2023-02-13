// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Write("Введите размер массива ");
int l=int.Parse(Console.ReadLine()!);
int k=l/2;
int n=0;

int[] numbers = new int[l];
int[] sum=new int[k];



for (int i = 0; i < numbers.Length; i++)
{
    numbers[i]= new Random().Next(0,100);
    Console.Write($" {numbers[i]} \t");
}
for (int i = 0; i <sum.Length; i++) 

{   n=numbers.Length-i-1;
    sum[i]=numbers[i]*numbers[n];

}
Console.WriteLine("\n Произведение пар массива равно");
for (int i = 0; i < sum.Length; i++)
{
    Console.Write($" {sum[i]} \t");
}
