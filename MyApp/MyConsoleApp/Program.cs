string name = "Ewa";
bool isWoman = true;
int age = 33;

if (isWoman)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
}
else if (age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyna");
}
else { 
    Console.WriteLine("Mężczyna");
}
