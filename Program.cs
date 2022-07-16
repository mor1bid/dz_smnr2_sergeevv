int index=999, count=0;
while (count<=index) 
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine()),
        workday = 5, 
        holiday = 7;
        if (num <= workday && num > 0)
        Console.WriteLine("Сегодня - рабочий день");
        else if (num <= holiday && num > workday)
        Console.WriteLine("Сегодня - выходной день");
        else 
        Console.WriteLine("Указано некорректное число. Повторите попытку.");
count++;
} 