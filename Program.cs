int index=999, count=0;
while (count<=index) 
{
    double money = 1000, grow = 0.015, moneygrow = money * grow, month=0;
    Console.WriteLine("Введите кол-во месяцев: ");
    double mymonth = Convert.ToInt32(Console.ReadLine());
    while (month<=mymonth) 
    {
        if (month % 2 == 0) 
        {
            //double moneygrow = money * grow;
            money += moneygrow;
        }
        month++;
    }
    Console.WriteLine("Размер депозита через " + mymonth + " месяцев будет равен " + money);
    count++;
} 