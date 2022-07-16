int index=999, count=0;
while (count<=index) 
{
    Console.WriteLine("Введите число: ");
    int numa = Convert.ToInt32(Console.ReadLine()), 
        two = numa % 100 / 10;
        Console.WriteLine(two);
count++;
} 