Console.Write("Введите  число: ");

string s = Console.ReadLine();
int i;


if (int.TryParse(s, out i))
{
    if ((i % 2) == 0)
    {
        Console.WriteLine("Четное");
    }
    else
    {
        Console.WriteLine(" Нечетное ");

    }


}
else
{
    Console.WriteLine("yps");

}
