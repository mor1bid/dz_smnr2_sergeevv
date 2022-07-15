void Zadacha10()
{
Console.WriteLine("Hello, World!");
}

void Zadacha13()
{
int index=999, count=0;
while (count<=index) {
    Console.WriteLine("Введите число: ");
    int numa = Convert.ToInt32(Console.ReadLine()), last = numa % 10; 
    if (numa > 100) 
    {
        Console.WriteLine(last); }
        else 
        {
        Console.WriteLine("третьей цифры нет");
        }
        count++;
    }
}

void Zadacha15()
{
Console.WriteLine("Hello, World!");
}