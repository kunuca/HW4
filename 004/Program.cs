// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] numbers = new int[15];
int sum=0;


for (int i = 0; i < numbers.Length; i++)
{
    numbers[i]= new Random().Next(0,100);
    Console.Write($" {numbers[i]} \t");
}
for (int i = 1; i < numbers.Length; i=i+2) sum=sum+numbers[i];

Console.WriteLine();
Console.Write($"Сумма чисел массива с нечетным индексом равна {sum}");