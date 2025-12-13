Console.WriteLine("Arvaa luku väliltä 0-100!");
string syote = Console.ReadLine();

Random random = new Random();
int oikeaLuku;

if (syote.StartsWith("#SECRET="))
{
    oikeaLuku = int.Parse(syote.Substring(8));
}
else
{
    oikeaLuku = random.Next(0, 101);
}

int arvattuLuku;

if (syote.StartsWith("#SECRET="))
{
    arvattuLuku = int.Parse(Console.ReadLine());
}
else
{
    arvattuLuku = int.Parse(syote);
}

while (arvattuLuku != oikeaLuku)
{
    if (arvattuLuku < oikeaLuku)
    {
        Console.WriteLine("Korkeampi");
    }
    else
    {
        Console.WriteLine("Alempi");
    }
    
    arvattuLuku = int.Parse(Console.ReadLine());


}
