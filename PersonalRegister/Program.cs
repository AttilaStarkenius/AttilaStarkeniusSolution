// See https://aka.ms/new-console-template for more information
using PersonalRegister;

Console.WriteLine("Hello, World!");
/*1.11.2022. I create a console application
 called "PersonalRegister" and set it as the startup project
in a solution called "AttilaStarkeniusSolution"
that is already added to Git Source Control, 
repository https://github.com/AttilaStarkenius/AttilaStarkeniusSolution
The instructions for .NET programming task is as follows: "C#Övning1-
PersonalregisterInlämningInstruktionerOBS! Kräver GitHub extension 
for Visual Studio samtett GitHub konto1.Add to source control nere i 
högra hörnet, välj git,Alternativt Git menyn Create GitRepository2.KryssaURCheckboxenPrivate
3.Create and Publish4.Kontrollera att repositoriet skapats i 
webbläsarenoch alla filer finns med. Om så är falletkan du hoppa över resten. 
Annars följ nästa steg.5.Gå till git changes i Visual Studio.6.Skriv in ett
commit meddelande tryck på Commit7.Efter det Push med pilen uppåt. Alternativt 
Sync medtvå pilar i en cirkel.8.Kontrollera enligt punkt 4.9.Klart
Finns även guide under kanalen Git att titta på!Se till att 
skicka upp koden med god marginal tillatt tiden är ute!
BakgrundEtt  litet företag i restaurangbranschen kontaktar
dig för att utveckla ett litetpersonalregister. De har endast två krav:
1.Registret skall kunna ta emot och lagra anställdamed namn och lön. 
(via inmatningi konsolen, inget krav på persistent lagring)
2.Programmet skall kunna skriva ut registret i en konsol.

Uppgift 1Vilkaklasserbör ingå i programmet? Svar: Employee

Uppgift 2Vilkaattributochmetoderbör ingå i dessa klasser? Employee borde
innehålla "id" av typen int för att identifiera Employee,
"name" av typen string och "salary" av typen double attributerna och
en nullable lista av typen "Employee"(listan är null då när
det finns inga employees, därför måste även typen av listan vara nullable).


Uppgift 3Skriv programmet

Försök göra programmet så robust och framtidssäkertsom möjligt!
Bonus för att implementera test!
(men inte på bekostnadav att den andra koden blirlidande)
Ni har fram till 16.45 på er, koden ska ligga uppeabsolut senast 17.00.Lycka till!"

 I start by writing readline: Console.WriteLine("Write your name:");
                var name = Console.ReadLine();
                Console.WriteLine("Enter your salary:");
                var salary = Console.ReadLine();*/
List<Employee>? employeeList = new List<Employee>();

/*1.11.2022. Jag committar och pushar till Git Changes 
 till URL https://github.com/AttilaStarkenius/AttilaStarkeniusSolution/PersonalRegister*/
Console.WriteLine("Write your name:");
employeeList.Add(new Employee(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()))
{
    name = Console.ReadLine()
});
Console.WriteLine("Enter your salary:");
var salary = Console.ReadLine();
