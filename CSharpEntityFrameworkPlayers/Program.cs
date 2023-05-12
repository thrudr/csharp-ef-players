using CSharpEntityFrameworkPlayers;
using System.Xml.Serialization;

bool go = true;
Console.WriteLine("------- MENU -------\n");
Console.WriteLine("1. Insert a new player");
Console.WriteLine("2. Serach and print a player by Id");
Console.WriteLine("3. Esci");
Console.WriteLine("\n-------------------\n");
while (go)
{
    Console.Write("Choose an option: ");
    int response = int.Parse(Console.ReadLine());
    switch (response)
    {
        case 1:
            Console.Write("Insert the name of the player: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Insert the surname : ");
            string cognome = Console.ReadLine();
            using (Basket db = new Basket())
            {
                Random random = new Random();
                double numeroPartiteVinte = random.NextDouble() * (9) + 1;
                int punteggio = random.Next(1, 101);
                int numeroPartiteGioccate = random.Next(1, punteggio);
                Player newPlayer = new Player(nome, cognome, punteggio, numeroPartiteGioccate, numeroPartiteVinte);
                db.Add(newPlayer);
                db.SaveChanges();
            }
            break;
        case 2:
            Console.Write("Insert the Id to search: ");
            break;
        case 3:
            Console.WriteLine("Thank you and goodbye");
            go = false;
            break;
        default:
            Console.WriteLine("Non hai inserito un'opzione valida! Ritenta!");
            break;
    }
}
