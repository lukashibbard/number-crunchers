int sum = 0;
int x = 0;
int y = 0;
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Random rand = new Random();
for (int i = 1; i < 10; i++)
{
    numbers[i] = rand.Next(1, 100);
    Array.Sort(numbers);
    Console.WriteLine(numbers[i]);
}
foreach (int number in numbers)
{
    sum = numbers[x] + sum;
    x++;
}
Console.WriteLine($"Sum: {sum}");
int mean = sum / 10;
Console.WriteLine($"Mean: {mean}");
int median = (numbers[5] + numbers[6]) / 2;
Console.WriteLine($"Median: {median}");
Console.Write("Modes: ");
for (int t = 1; k < 10; t++)
{
    if (numbers[y] == numbers[y + 1])
    {
        Console.WriteLine(numbers[y+1]);
    }
    y++;
}

