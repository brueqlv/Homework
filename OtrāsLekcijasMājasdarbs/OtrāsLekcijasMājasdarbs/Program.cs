
//Pirmais uzdevums
Console.WriteLine("Ievadi savu vārdu!");
string name = Console.ReadLine();
Console.WriteLine($"Labdien, {name}!");
Console.ReadLine();

//Otrais uzdevums
Console.WriteLine("Ievadi savu vecumu!");
int yearsOld = int.Parse(Console.ReadLine());
int nextYear = yearsOld + 1;
bool adult = yearsOld >= 18;
Console.WriteLine($"Nākamgad Tev paliks {nextYear}! {adult}");
Console.ReadLine();

//Trešais uzdevums
Console.WriteLine("Ievadi pirmo skaitli!");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Ievadi otro skaitli");
int secondNumber = int.Parse(Console.ReadLine());
int biggestNumber = Math.Max(firstNumber, secondNumber);
Console.WriteLine($"Lielākais skaitlis ir: {biggestNumber}");
Console.ReadLine();

//Ceturtais uzdevums
Console.WriteLine("Ievadi pirmo skaitli!");
int thirdNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Ievadi otro skaitli!");
int fourthNumber = int.Parse(Console.ReadLine());
int smallestNumber = Math.Min(thirdNumber, fourthNumber);
Console.WriteLine($"Mazākais skaitlis ir: {smallestNumber}");
Console.ReadLine();

//Piektais uzdevums
Console.WriteLine("Ievadi pirmo skaitli!");
int fifthNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Ievadi otro skaitli!");
int sixtNumber = int.Parse(Console.ReadLine());
int surplus = fifthNumber % sixtNumber;
Console.WriteLine($"Dalījuma atlikums ir: {surplus}");
Console.ReadLine();

//Sestais uzdevums
Console.WriteLine("Ievadi skaitli!");
int seventhNumber = int.Parse(Console.ReadLine());
if (seventhNumber % 2 == 0)
{
    Console.WriteLine("Ievadītais skaitlis ir Pāra!");
}
else
{
    Console.WriteLine("Ievadītais skaitlis ir nepāra!");
}
Console.ReadLine();

//Septītais uzdevums
Console.WriteLine("Ievadi taisnstūra pirmās malas garumu! (Metros)");
decimal firstSide = decimal.Parse(Console.ReadLine());
Console.WriteLine("Ievadi taisnstūra otrās malas garumu! (Metros)");
decimal secondSide = decimal.Parse(Console.ReadLine());
decimal area = firstSide * secondSide;
Console.WriteLine($"Taisnstūra laukums ir: {area}m²");
Console.ReadLine();

//Astotais uzdevums
Console.WriteLine("Ievadiet vienādsānu trijstūra malas garumu! (Metros)");
decimal triangleSide = decimal.Parse(Console.ReadLine());
decimal triangleArea = triangleSide * triangleSide / 2;
Console.WriteLine($"Dotā vienādsānu trijstūra lukums ir: {triangleArea}m²");
Console.ReadLine();

//Devītais uzdevums
Console.WriteLine("Ievadi savu vārdu!");
string name1 = Console.ReadLine();
Console.WriteLine("Ievadi savu vecumu!");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"Sveiks, {name1}! Tev šobrīd ir {age} gadi!");
Console.ReadLine();



