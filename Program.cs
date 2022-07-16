int index=999, count=0;
while (count<=index) 
{
    Console.WriteLine("Введите значения сторон треугольника: ");
    int a = Convert.ToInt32(Console.ReadLine()), 
        b = Convert.ToInt32(Console.ReadLine()), 
        c = Convert.ToInt32(Console.ReadLine());
if (a == b )//&& c == b && a == c) 
{
Console.WriteLine("Данный треугольник abc - равнобедренный");
}
else
Console.WriteLine("Данный треугольник abc - неравнобедренный");
count++;
} 