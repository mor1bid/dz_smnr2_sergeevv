int index=999, count=0;
while (count<=index) 
{
    Console.WriteLine("Введите дату рождения: ");
    int myday = Convert.ToInt32(Console.ReadLine()), 
        mymonth = Convert.ToInt32(Console.ReadLine()),
        myyear = Convert.ToInt32(Console.ReadLine()),
        day = 1, month = 7, year = 2022, old=0;
    while (myyear <= year) 
    {
    old++; 
    }
    Console.WriteLine("Вам " + old);
count++;
} 