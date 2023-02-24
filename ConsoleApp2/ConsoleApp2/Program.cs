//liczby całkowite

using System.ComponentModel.Design;
using System.Xml;

int myAge = 15;

int age = myAge + 10;
Console.WriteLine(age);
int myVar = int.MinValue;
ulong var3 = ulong.MaxValue;

//liczby zmienno przecinkowe

float var4 = float.MinValue;
float var5 = float.MaxValue;
double number = double.MaxValue;

// zmienne tekstowe

string Name = "Kamil";
string surName = "B";
string result = Name + surName + age;
Console.WriteLine(result);

char myVar1 = 'a';
var resoult2 = Name.ToArray();

//zmienna logiczna
bool isActive = true;
isActive = false;
var isValid = 4 > 3;
Console.WriteLine(isValid);


//==
//!=
//<=
//>=

var number1 = 3;
    var number2 = 1;

if (number1 > number2)
{
 Console.WriteLine("jestem w lini 6");
}
else
{
    Console.WriteLine("Jestem w lini 10");
}
//&& i
// || lub
//! negacja

var Name1 = "Kamil";
var Age1 = 21;
if (Name1 == "Kamul" || Age1 < 21)
{
    Console.WriteLine(11111);
}
else
{
    Console.WriteLine(22222);
}

if (!(Age1 < 30))
{
    Console.WriteLine(11111);
}
else
{
    Console.WriteLine(22222);
}
