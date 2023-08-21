Console.Write("Введите  число: ");

string s = Console.ReadLine();
int i;
int z ;


if (int.TryParse(s, out i))
{
    for (z = 1; z < i; z++)
    {
        if ((z % 2 == 0))
        {
            Console.WriteLine(z);
        }

    }



}



else
{
    Console.WriteLine("yps");

}
