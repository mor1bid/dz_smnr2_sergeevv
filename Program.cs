int index=999, count=0;
while (count<=index) 
{
    int day = 1, month = 7, year = 2022;
    Console.WriteLine("Введите день, месяц и год вашего рождения: ");
    int myday = Convert.ToInt32(Console.ReadLine()), 
        mymonth = Convert.ToInt32(Console.ReadLine()),
        myyear = Convert.ToInt32(Console.ReadLine());
    if (myday <= 31) 
    {
    myday = day-myday;
    Console.WriteLine("Вам " + myday + " дней, "); 
    }
    else if (mymonth <= 12) 
    {
    mymonth = month-mymonth;
    Console.WriteLine("Вам " + mymonth + " месяцев, ");
    }
    else if (myyear <= year) 
    {
    myyear = year-myyear;
    Console.WriteLine(myyear + " года.");
    }
    else
    Console.WriteLine("Введена некорректная дата");
count++;
} 