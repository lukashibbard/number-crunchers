int sum = 0;
int j = 0;
int l = 0;
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Random rand = new Random();
for (int i = 0; i < 9; i++)
{
    numbers[i] = rand.Next(1, 100);
    Array.Sort(numbers);
    Console.WriteLine(numbers[i]);
}
foreach (int number in numbers)
{
    sum = numbers[j] + sum;
    j++;
}
Console.WriteLine($"Sum: {sum}");
int mean = sum / 10;
Console.WriteLine($"Mean: {mean}");
int median = (numbers[5] + numbers[6]) / 2;
Console.WriteLine($"Median: {median}");
Console.Write("Modes: ");
for (int k = 0; k < 9; k++)
{
    if (numbers[l] == numbers[l + 1])
    {
        Console.WriteLine(numbers[l+1]);
    }
    l++;
}
