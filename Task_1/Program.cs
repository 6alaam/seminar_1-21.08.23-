Console.Write("Введите два числа: ");

string s = Console.ReadLine();
string s2 = Console.ReadLine();
int i ;
int z ;

if(int.TryParse(s,out i) && int.TryParse(s2, out z) ){
    if(i > z){
        Console.WriteLine(i + " больше " + z);
    }
    else {
        Console.WriteLine(z + " больше " + i);

    }
    
    
}
else{
    Console.WriteLine("yps");
    
}
