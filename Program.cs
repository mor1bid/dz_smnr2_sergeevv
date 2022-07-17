int index=999, count=0;
while (count<=index) 
{
    int day = 1, month = 7, year = 2022;
    Console.WriteLine("Введите день, месяц и год вашего рождения: ");
    int myday = Convert.ToInt32(Console.ReadLine()), 
        mymonth = Convert.ToInt32(Console.ReadLine()),
        myyear = Convert.ToInt32(Console.ReadLine());
    if (myday <= 31 && mymonth <= 12 && myyear < year && 
        myday > day && mymonth > month) 
    {
    myday = day-myday;
    mymonth = month-mymonth;
    myyear = year-myyear-1;
    Console.WriteLine("Вам " + myday + " дней, " 
    + mymonth + " месяцев, " + myyear + " года.");
    } 
    else if (myday < day && mymonth < month) 
    {
        myyear = year-myyear;
        Console.WriteLine("Вам " + myday + " дней, " 
        + mymonth + " месяцев, " + myyear + " года."); 
    } 
    else 
    {
        Console.WriteLine("Введена некорректная дата"); 
    }
count++;
} 