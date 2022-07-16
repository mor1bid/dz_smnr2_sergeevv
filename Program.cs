int index=999, count=0;
while (count<=index) {
    Console.WriteLine("Введите число: ");
    int numa = Convert.ToInt32(Console.ReadLine()), 
        lasta = numa % 10, 
        lastb = (numa % 1000) / 10000; 
    if (numa > 1000) 
    {
        //lastb %= 100;
        Console.WriteLine(lastb); }
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