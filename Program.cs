Console.WriteLine("введите начальное значение");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите конечное число");
int b= Convert.ToInt32(Console.ReadLine());
int c = 0;
int i = a;
while (i <= b)
{
    if (i % 12 == 0)
    {
        c++;
    }
    i++;
}
Console.WriteLine(c);




