int index=999, count=0;
while (count<=index) 
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine()), 
        two = num % 100 / 10;
        if (num>1000 && num<99) 
        {
        Console.WriteLine(two);
        } 
        else 
        Console.WriteLine("Число " + num + " не является трёхзначным!");
count++;
} 