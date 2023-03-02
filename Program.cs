Console.Write("Введите трехзначное писло:");
try
{
    int Value = Convert.ToInt32(Console.ReadLine());
    int Length = Value.ToString().Length;
    if (Length == 3)
    {
        int result = (Value / 10) % 10;
        Console.WriteLine($"Вторая цифра:  {result}");
    }
    else
    {
        Console.WriteLine("Не трехзначное писло");
    }
}
catch (System.Threading.ThreadAbortException)
{
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}