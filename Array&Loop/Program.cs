//task1
string[] name = { "Nazrin", "Aysu", "Ayxan", "Fariz", "Gunay", "Azer" };

int count = 0;
foreach (string item in name)
{
    if (item.StartsWith("A", StringComparison.OrdinalIgnoreCase))
    {

        count++;
    }
}

Console.WriteLine($"'A' herfi ile baslayan adlarin sayi: {count}");

//task2

int[] numbers = { 45, 34, 23, 65, 32, 14, 73, 36};

int max = numbers[0];
int min = numbers[0];

foreach (int item in numbers)
{
    if (item > max)
    {
        max = item;
    }
    else if (item < min)
    {
        min = item;
    }


}

double average = (max + min) / 2.0;

Console.WriteLine("Verilmis ededler icersinde en boyuk ve en kicik ededin ededi ortasi: " + average + " beraberdir.");

//task3

Console.Write("Dördreqemli eded daxil edin: ");
int n = int.Parse(Console.ReadLine());

int ters = 0;
int temp = n;
while (temp > 0)
{
  ters = ters * 10 + temp % 10;
    temp /= 10;
}

// Palindrom olub olmadığını yoxlayaq
if (ters == n)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
