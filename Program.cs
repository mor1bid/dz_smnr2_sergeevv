int index=999, count=0;
while (count<=index) {
    Console.WriteLine("Введите число: ");
    int numa = Convert.ToInt32(Console.ReadLine()), lasta = numa % 10, lastb = numa % 100; 
    if (numa > 1000) 
    {
        Console.WriteLine(lastb); }
        else if (numa > 1000) 
        {
            Console.WriteLine(lasta);
        }
        else 
        {
            Console.WriteLine("третьей цифры нет");
        }
        count++;
    }