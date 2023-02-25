

using System.Xml.Linq;

var myAge = 22;
var myName = "Kamil";
var male = true;


if (myName == "Kamil" || myAge == 22)
{
    Console.WriteLine(myName + " lat" + myAge + "Płeć" + male);
}
else if (myAge < 13)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (male == false)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (myName == "Ewa" && myAge == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
