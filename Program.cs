int index=999, count=0;
while (count<=index) 
{
    double money = 1000, grow = 1.5, month=0;
    Console.WriteLine("Введите кол-во месяцев: ");
    double mymonth = Convert.ToInt32(Console.ReadLine());
    while (month<=mymonth) 
    {
        if (month % 2 == 0) 
        {
            double moneygrow = money * grow / 100; //Чтобы получать полный ответ
            money += moneygrow;
        }
        month++;
    }
    Console.WriteLine("Размер депозита через " + mymonth + " месяцев будет равен " + money);
    count++;
} 