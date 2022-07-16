int index=999, count=0;
while (count<=index) 
{
    int year = 2022, old=0;
    Console.WriteLine("Введите дату рождения: ");
    int //myday = Convert.ToInt32(Console.ReadLine()), 
        //mymonth = Convert.ToInt32(Console.ReadLine()),
        myyear = Convert.ToInt32(Console.ReadLine());
    while (myyear < year) 
    {
    myyear++; 
    }
    myyear %= 100;
    Console.WriteLine("Вам " + old);
count++;
} 