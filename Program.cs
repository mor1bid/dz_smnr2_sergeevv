int index=999, count=0;
while (count<=index) 
{
    Console.WriteLine("Введите число: ");
    ulong numa = Convert.ToUInt64(Console.ReadLine()), 
        lasta = numa % 10, 
        lastb = numa % 100 / 10,
        ten = 10;
        while (numa>=100)
    {
        if (numa < 1000)
        {
            Console.WriteLine(lasta);
            break;
        }
        else if (numa > 1000)
        {
            lastb %= ten;
            Console.WriteLine(lastb);
            ten++;
            break;
        }
        else 
        {
            Console.WriteLine("третьего числа нет");
        }
    }
    count++;
}