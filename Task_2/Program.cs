Console.Write("Введите два числа: ");

string s = Console.ReadLine();
string s2 = Console.ReadLine();
string s3 = Console.ReadLine();

int i;
int y;
int z;
int max;



if (int.TryParse(s, out i) && int.TryParse(s2, out y) && int.TryParse(s3, out z))
{
    max = i;

    if (y > max)
    {
        max = y;
    }
    if (z > max)
    {
        max = z;

    }
    Console.WriteLine("max =" + max);


}
else
{
    Console.WriteLine("yps");
}