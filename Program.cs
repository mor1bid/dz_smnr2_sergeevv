int index=999, count=0;
while (count<=index) 
{
    double money = 1000, grow = 15, month=0;
    Console.WriteLine("Введите кол-во месяцев: ");
    double mymonth = Convert.ToInt32(Console.ReadLine());
    while (month<=mymonth) 
    {
        if (month % 2 == 0) 
        {
            money += grow;
        }
        month++;
    }
    Console.WriteLine("Размер депозита через " + mymonth + " месяцев будет равен " + money);
    count++;
} 