
// Slack uzduotys /////////////////////////////////////
// 1 Uzduotis /////////////////////////////////////////
///////////////////////////////////////////////////////

/*
Console.WriteLine("Iveskite savo varda: ");
string Vardas = Console.ReadLine();
Console.WriteLine($"Labas, {Vardas}");
*/

///////////////////////////////////////////////////////
// 2 Uzduotis /////////////////////////////////////////
///////////////////////////////////////////////////////

/*
Console.WriteLine("Iveskite pirma skaiciu: ");
int Number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Iveskite antra skaiciu: ");
int Number2 = int.Parse(Console.ReadLine());
Number1 += Number2;
Console.WriteLine($"Skaiciu suma: {Number1}");
*/

///////////////////////////////////////////////////////
// 3 Uzduotis /////////////////////////////////////////
///////////////////////////////////////////////////////

/*
Console.WriteLine("Iveskite savo amziu: ");
byte Amzius = byte.Parse(Console.ReadLine());
Amzius += 5;
Console.WriteLine($"Jusu amzius po 5 metu: {Amzius}");
*/

///////////////////////////////////////////////////////
// 4 Uzduotis /////////////////////////////////////////
///////////////////////////////////////////////////////

/*
Console.WriteLine("Iveskite staciakampio ilgi: ");
double Ilgis = double.Parse(Console.ReadLine());
Console.WriteLine("Iveskite staciakampio ploti: ");
double Plotis = double.Parse(Console.ReadLine());
Ilgis *= Plotis;
Console.WriteLine($"Staciakampio plotas: {Ilgis}");
*/

///////////////////////////////////////////////////////
// 5 Uzduotis /////////////////////////////////////////
///////////////////////////////////////////////////////

/*
Console.WriteLine("Iveskite skaiciu: ");
int Skaicius = int.Parse(Console.ReadLine());
if( Skaicius % 2 == 0 )
    Console.WriteLine("Skaicius yra lyginis");
else
    Console.WriteLine("Skaicius yra nelyginis");
*/



// Kurso uzduotys /////////////////////////////////////
// 1 Uzduotis /////////////////////////////////////////
///////////////////////////////////////////////////////

/*
Console.WriteLine("Iveskite savo varda: ");
string Vardas = Console.ReadLine();

Console.WriteLine("Iveskite savo pavarde: ");
string Pavarde = Console.ReadLine();

Console.WriteLine("Iveskite savo gimimo metus: ");
int GimimoMetai = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite siuos metus: ");
int SieMetai = int.Parse(Console.ReadLine());

Console.WriteLine($"As esu {Vardas} {Pavarde}. Man yra {SieMetai-GimimoMetai}");
*/

///////////////////////////////////////////////////////
// 2 Uzduotis /////////////////////////////////////////
///////////////////////////////////////////////////////

/*
Random Rnd = new Random();

decimal RandomDecimal1 = Rnd.Next(1, 6);
decimal RandomDecimal2 = Rnd.Next(1, 6);
decimal Rezultatas;

Console.WriteLine($"Sugeneruoti skaiciai: {RandomDecimal1} ir {RandomDecimal2}");

if (RandomDecimal1 > RandomDecimal2)
    Rezultatas = RandomDecimal1 / RandomDecimal2;
else 
    Rezultatas = RandomDecimal2 / RandomDecimal1;

Rezultatas = Math.Round(Rezultatas, 2);
Console.WriteLine($"Rezultatas: {Rezultatas}");
*/

///////////////////////////////////////////////////////
// 3 Uzduotis /////////////////////////////////////////
///////////////////////////////////////////////////////

/*
Random Rnd = new Random();

int RandomNumber1 = Rnd.Next(0, 26);
int RandomNumber2 = Rnd.Next(0, 26);
int RandomNumber3 = Rnd.Next(0, 26);
int Rezultatas;

Console.WriteLine($"Sugeneruoti skaiciai: {RandomNumber1}, {RandomNumber2} ir {RandomNumber3}");

if( RandomNumber1 >= RandomNumber2 && RandomNumber1 >= RandomNumber3 )
{
    if (RandomNumber2 >= RandomNumber3)
        Rezultatas = RandomNumber2;
    else 
        Rezultatas = RandomNumber3;
}
else if (RandomNumber2 >= RandomNumber1 && RandomNumber2 >= RandomNumber3)
{
    if (RandomNumber1 >= RandomNumber3)
        Rezultatas = RandomNumber1;
    else 
        Rezultatas = RandomNumber3;
}
else if (RandomNumber3 >= RandomNumber1 && RandomNumber3 >= RandomNumber2)
{
    if (RandomNumber1 >= RandomNumber2)
        Rezultatas = RandomNumber1;
    else 
        Rezultatas = RandomNumber2;
}

Console.WriteLine($"Rezultatas: {Rezultatas}");
*/

///////////////////////////////////////////////////////
// 4 Uzduotis /////////////////////////////////////////
///////////////////////////////////////////////////////

/*
Random Rnd = new Random();

int A = Rnd.Next(1, 11);
int B = Rnd.Next(1, 11);
int C = Rnd.Next(1, 11);
bool bTrikampis = true;

Console.WriteLine($"Sugeneruoti krastiniu ilgiai: {A}, {B} ir {C}");

if( A + B - C <= 0 )
    bTrikampis = false;
else if( A + C - B <= 0 )
    bTrikampis = false;
else if (B + C - A <= 0 )
    bTrikampis = false;

Console.WriteLine($"Trikampi galima sudaryti: {bTrikampis}");
*/

///////////////////////////////////////////////////////
// 5 Uzduotis /////////////////////////////////////////
///////////////////////////////////////////////////////

/*
Random Rnd = new Random();

int RandomNumber1 = Rnd.Next(0, 3);
int RandomNumber2 = Rnd.Next(0, 3);
int RandomNumber3 = Rnd.Next(0, 3);
int RandomNumber4 = Rnd.Next(0, 3);
byte Nuliai = 0;
byte Vienetai = 0;
byte Dvejetai = 0;

Console.WriteLine($"Sugeneruoti skaiciai: {RandomNumber1}, {RandomNumber2}, {RandomNumber3} ir {RandomNumber4}");

switch (RandomNumber1)
{
    case 0:
        ++Nuliai;
        break;
    case 1:
        ++Vienetai;
        break;
    case 2:
        ++Dvejetai;
        break;
}

switch (RandomNumber2)
{
    case 0:
        ++Nuliai;
        break;
    case 1:
        ++Vienetai;
        break;
    case 2:
        ++Dvejetai;
        break;
}

switch (RandomNumber3)
{
    case 0:
        ++Nuliai;
        break;
    case 1:
        ++Vienetai;
        break;
    case 2:
        ++Dvejetai;
        break;
}

switch (RandomNumber4)
{
    case 0:
        ++Nuliai;
        break;
    case 1:
        ++Vienetai;
        break;
    case 2:
        ++Dvejetai;
        break;
}

Console.WriteLine($"Nuliai: {Nuliai}, Vienetai: {Vienetai}, Dvejetai: {Dvejetai}");
*/

///////////////////////////////////////////////////////
// 6 Uzduotis /////////////////////////////////////////
///////////////////////////////////////////////////////

/*
Random Rnd = new Random();

int RandomNumber1 = Rnd.Next(-10, 11);
int RandomNumber2 = Rnd.Next(-10, 11);
int RandomNumber3 = Rnd.Next(-10, 11);

Console.Write("Sugeneruoti skaiciai: ");

if (RandomNumber1 > 0)
    Console.Write("{" + RandomNumber1 + "}, ");
else if (RandomNumber1 < 0)
    Console.Write("[" + RandomNumber1 + "], ");
else
    Console.Write("(" + RandomNumber1 + "), ");

if (RandomNumber2 > 0)
    Console.Write("{" + RandomNumber2 + "}, ");
else if (RandomNumber2 < 0)
    Console.Write("[" + RandomNumber2 + "], ");
else
    Console.Write("(" + RandomNumber2 + "), ");

if (RandomNumber3 > 0)
    Console.Write("{" + RandomNumber3 + "}");
else if (RandomNumber3 < 0)
    Console.Write("[" + RandomNumber3 + "]");
else
    Console.Write("(" + RandomNumber3 + ")");
*/

///////////////////////////////////////////////////////
// 7 Uzduotis /////////////////////////////////////////
///////////////////////////////////////////////////////

/*
Random Rnd = new Random();

int ZvakiuKiekis = Rnd.Next(5, 3001);
decimal ZvakesKaina;

Console.WriteLine($"Sugeneruotas zvakiu kiekis: {ZvakiuKiekis}");

if(ZvakiuKiekis <= 1000)
    ZvakesKaina = 1.00M;
else if (ZvakiuKiekis <= 2000)
    ZvakesKaina = 0.97M;
else ZvakesKaina = 0.96M;

Console.WriteLine($"Vienos zvakes kaina: {ZvakesKaina} EUR");
ZvakesKaina = ZvakiuKiekis * ZvakesKaina;
Console.WriteLine($"Bendra kaina: {ZvakesKaina} EUR");
*/

///////////////////////////////////////////////////////
// 8 Uzduotis /////////////////////////////////////////
///////////////////////////////////////////////////////

/*
Random Rnd = new Random();

decimal RandomDecimal1 = Rnd.Next(0, 101);
decimal RandomDecimal2 = Rnd.Next(0, 101);
decimal RandomDecimal3 = Rnd.Next(0, 101);
decimal Vidurkis;
byte Kiekis = 0;

Console.WriteLine($"Sugeneruoti skaiciai: {RandomDecimal1}, {RandomDecimal2} ir {RandomDecimal3}");

Vidurkis = Math.Round((RandomDecimal1 + RandomDecimal2 + RandomDecimal3) / 3);
Console.WriteLine($"Vidurkis: {Vidurkis}");

Vidurkis = 0M;
if(RandomDecimal1>9 && RandomDecimal1 < 91)
{
    Vidurkis += RandomDecimal1;
    ++Kiekis;
}
if (RandomDecimal2 > 9 && RandomDecimal2 < 91)
{
    Vidurkis += RandomDecimal2;
    ++Kiekis;
}
if (RandomDecimal3 > 9 && RandomDecimal3 < 91)
{
    Vidurkis += RandomDecimal3;
    ++Kiekis;
}
Vidurkis = Math.Round(Vidurkis / Kiekis);
Console.WriteLine($"Vidurkis atmetus reiksmes, kurios yra mazesnes uz 10 ir didesnes uz 90: {Vidurkis}");
*/

///////////////////////////////////////////////////////
// 9 Uzduotis /////////////////////////////////////////
///////////////////////////////////////////////////////

/*
Random Rnd = new Random();

int Valandos = Rnd.Next(0, 24);
int Minutes = Rnd.Next(0, 60);
int Sekundes = Rnd.Next(0, 60);
int ExtraSekundes = Rnd.Next(0, 301);
string Laikas = "Sugeneruotas laikas: ";

Laikas = Valandos < 10 ? Laikas + "0" + Valandos + ":" : Laikas + Valandos + ":";
Laikas = Minutes < 10 ? Laikas + "0" + Minutes + ":" : Laikas + Minutes + ":";
Laikas = Sekundes < 10 ? Laikas + "0" + Sekundes : Laikas + Sekundes;

Console.WriteLine(Laikas);
Console.WriteLine($"Papildomos sekundes: {ExtraSekundes}");

if(ExtraSekundes > 0)
{
    Sekundes += ExtraSekundes;
    if(Sekundes > 59)
    {
        Minutes += (Sekundes - (Sekundes % 60)) / 60;
        Sekundes = Sekundes % 60;
    }
    if (Minutes > 59)
    {
        Valandos += (Minutes - (Minutes % 60)) / 60;
        Minutes = Minutes % 60;
    }
    if (Valandos > 23)
        Valandos -= 24;
}

Laikas = "";
Laikas = Valandos < 10 ? Laikas + "0" + Valandos + ":" : Laikas + Valandos + ":";
Laikas = Minutes < 10 ? Laikas + "0" + Minutes + ":" : Laikas + Minutes + ":";
Laikas = Sekundes < 10 ? Laikas + "0" + Sekundes : Laikas + Sekundes;
Console.WriteLine($"Naujas laikas: {Laikas}");
*/

///////////////////////////////////////////////////////
// 10 Uzduotis ////////////////////////////////////////
///////////////////////////////////////////////////////

/*
Random Rnd = new Random();

int Random1 = Rnd.Next(1000, 10000);
int Random2 = Rnd.Next(1000, 10000);
int Random3 = Rnd.Next(1000, 10000);
int Random4 = Rnd.Next(1000, 10000);
int Random5 = Rnd.Next(1000, 10000);
int Random6 = Rnd.Next(1000, 10000);
int Temporary;

Console.WriteLine($"Sugeneruoti skaiciai: {Random1} {Random2} {Random3} {Random4} {Random5} {Random6}");

if( Random2 > Random1 )
{
    Temporary = Random2;
    Random2 = Random1;
    Random1 = Temporary;
}
if (Random3 > Random1)
{
    Temporary = Random3;
    Random3 = Random1;
    Random1 = Temporary;
}
if (Random4 > Random1)
{
    Temporary = Random4;
    Random4 = Random1;
    Random1 = Temporary;
}
if (Random5 > Random1)
{
    Temporary = Random5;
    Random5 = Random1;
    Random1 = Temporary;
}
if (Random6 > Random1)
{
    Temporary = Random6;
    Random6 = Random1;
    Random1 = Temporary;
}

if (Random3 > Random2)
{
    Temporary = Random3;
    Random3 = Random2;
    Random2 = Temporary;
}
if (Random4 > Random2)
{
    Temporary = Random4;
    Random4 = Random2;
    Random2 = Temporary;
}
if (Random5 > Random2)
{
    Temporary = Random5;
    Random5 = Random2;
    Random2 = Temporary;
}
if (Random6 > Random2)
{
    Temporary = Random6;
    Random6 = Random2;
    Random2 = Temporary;
}

if (Random4 > Random3)
{
    Temporary = Random4;
    Random4 = Random3;
    Random3 = Temporary;
}
if (Random5 > Random3)
{
    Temporary = Random5;
    Random5 = Random3;
    Random3 = Temporary;
}
if (Random6 > Random3)
{
    Temporary = Random6;
    Random6 = Random3;
    Random3 = Temporary;
}

if (Random5 > Random4)
{
    Temporary = Random5;
    Random5 = Random4;
    Random4 = Temporary;
}
if (Random6 > Random4)
{
    Temporary = Random6;
    Random6 = Random4;
    Random4 = Temporary;
}

if (Random6 > Random5)
{
    Temporary = Random6;
    Random6 = Random5;
    Random5 = Temporary;
}

Console.WriteLine($"Surusiuoti skaiciai: {Random1} {Random2} {Random3} {Random4} {Random5} {Random6}");
*/