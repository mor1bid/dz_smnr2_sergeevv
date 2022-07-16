int index=999, count=0;
while (count<=index) 
{
    int day = 1, month = 7, year = 2022;
    Console.WriteLine("Введите дату рождения: ");
    int myday = Convert.ToInt32(Console.ReadLine()), 
        mymonth = Convert.ToInt32(Console.ReadLine()),
        myyear = Convert.ToInt32(Console.ReadLine());
    if (mymonth <= 31) 
    {
    myday = day-myday;
    Console.WriteLine("Вам " + myday + " дней, ");
    }
    else
    Console.WriteLine("Введена некорректная дата");

    if (mymonth <= 12) 
    {
    mymonth = month-mymonth;
    Console.WriteLine("Вам " + mymonth + " месяцев, ");
    }
    else
    Console.WriteLine("Введена некорректная дата");
    
    if (myyear <= year) 
    {
    myyear = year-myyear;
    Console.WriteLine(myyear + " года.");
    }
    else
    Console.WriteLine("Введена некорректная дата");
count++;
} 