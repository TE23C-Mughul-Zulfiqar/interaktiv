using System.Formats.Asn1;

string val = "";

Console.WriteLine("Klockan är 03:00 och du är ute och går");
Console.WriteLine("Du hittar en väg men den ser lite skum ut");
Console.WriteLine("Du kan fortsätta framåt men du får en dålig känsla");
Console.WriteLine("Du kan gå tillbaka men det är inte helt säkert");
Console.WriteLine("Går du fram så kommer du hem snabbare ");
Console.WriteLine("Vart går du? Framåt eller tillbaka?");

val = Console.ReadLine();
val = val.ToLower();

if (val == "framåt")
{
  Console.WriteLine("Du kommer går långsmat genom vägen och får den dålig känsla");
  Console.WriteLine("Du börjar springa och du hör någon följa efter dig");
  Console.WriteLine("Du lyckas komma hem");
  Console.WriteLine("Du märker att du har glömt dina nycklar");
  Console.WriteLine("Du kan hoppa genom fönstret som är öppet eller springa bak och använda bakdörren");
  Console.WriteLine("Vilken väljer du? Fönster eller Bakdörren?");

  val = Console.ReadLine();
  val = val.ToLower();

  if (val == "fönster")
  {
    Console.WriteLine("Du har lyckats ta dig hem!");
    Console.WriteLine("Du stänger alla fönster och låser alla dörrar");
    Console.WriteLine("Du går och lägger dig direkt");
    Console.WriteLine("Du klarar dig tills imorgon och vaknar upp till en solig morgon");
  }
  {
  if (val == "bakdörren")
  {
   Console.WriteLine("Du hör fotstegen närma sig");
   Console.WriteLine("Du får panik");
   Console.WriteLine("Du springer bak till bakdörren");
   Console.WriteLine("Personen springer ikapp dig");
   Console.WriteLine("Du blir bli knivhuggen");
   Console.WriteLine("Du DÖR!");
  }
  

  val = Console.ReadLine();
  val = val.ToLower();
  }
  


}
else if (val == "tillbaka")
{
  Console.WriteLine("Du vänder dig.");
  Console.WriteLine("Du hör något prassla bakom dig");
  Console.WriteLine("Du börjar springa ");
  Console.WriteLine("Någon springer efter dig");
  Console.WriteLine("Du DOG!");

  val = Console.ReadLine();
  val = val.ToLower();
  
}
Console.WriteLine("Slut.");
Console.WriteLine("Tryck på ENTER för att avsluta.");
Console.ReadLine();