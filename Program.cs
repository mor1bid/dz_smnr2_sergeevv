int index=999, count=0;
while (count<=index) {
    Console.WriteLine("Введите число: ");
    ulong numa = Convert.ToUInt32(Console.ReadLine()), 
        lasta = numa % 10, 
        lastb = numa % 100 / 10; 
    if (numa > 10000) 
    {
        lastb = (numa % 100000 / 10000) % 10;
        Console.WriteLine(lastb); }
        else if (numa > 1000)
        {
            Console.WriteLine(lastb);
        }
        else if (numa > 100) 
        {
            Console.WriteLine(lasta);
        }
        else 
        {
            Console.WriteLine("третьей цифры нет");
        }
        count++;
    }