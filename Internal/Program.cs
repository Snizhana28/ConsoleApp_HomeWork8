using ConsoleApp_HomeWork8.Domain;

namespace ConsoleApp_HomeWork8.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FootballTeam footballTeam = new FootballTeam("Dynamo");

            footballTeam.AddPlayer(new Players("Georgiy Bushchan", 29, 1, "goalkeeper"));
            footballTeam.AddPlayer(new Players("Denis Boiko", 35, 71, "goalkeeper"));
            footballTeam.AddPlayer(new Players("Oleksandr Syrota", 23, 34, "defender"));
            footballTeam.AddPlayer(new Players("Oleksandr Tymchyk", 26, 24, "defender"));
            footballTeam.AddPlayer(new Players("Artem Shabanov", 31, 13, "defender"));
            footballTeam.AddPlayer(new Players("Vladyslav Dubinchak", 25, 4, "defender"));
            footballTeam.AddPlayer(new Players("Denys Popov", 24, 81, "defender"));
            footballTeam.AddPlayer(new Players("Kostiantyn Vivcharenko", 21, 5, "defender"));
            footballTeam.AddPlayer(new Players("Maksym Dyachuk", 20, 25, "defender"));
            footballTeam.AddPlayer(new Players("Mykyta Burda", 28, 6, "defender"));
            footballTeam.AddPlayer(new Players("Anton Tsarenko", 19, 37, "midfielder"));
            footballTeam.AddPlayer(new Players("Vitaliy Buyalsky", 30, 29, "midfielder"));
            footballTeam.AddPlayer(new Players("Vladimir Shepelev", 26, 8, "midfielder"));
            footballTeam.AddPlayer(new Players("Justin Lonwake", 23, 22, "midfielder"));
            footballTeam.AddPlayer(new Players("Alexander Karavayev", 31, 20, "midfielder"));
            footballTeam.AddPlayer(new Players("Benito Olabiran Muiva", 25, 77, "midfielder"));
            footballTeam.AddPlayer(new Players("Denis Garmash", 33, 19, "midfielder"));
            footballTeam.AddPlayer(new Players("Andriy Yarmolenko", 33, 7, "forward"));
            footballTeam.AddPlayer(new Players("Vladyslav Supryaga", 23, 89, "forward"));
            footballTeam.AddPlayer(new Players("Mykola Shaparenko", 24, 10, "forward"));
            footballTeam.AddPlayer(new Players("Sambi Diallo", 20, 30, "forward"));
            footballTeam.AddPlayer(new Players("Artem Besedin", 27, 41, "forward"));
            footballTeam.AddPlayer(new Players("Vladyslav Vanat", 21, 74, "forward"));
            footballTeam.AddPlayer(new Players("Vladislav Kulach", 30, 28, "forward"));
            footballTeam.AddPlayer(new Players("Ilya Shkurin", 24, 73, "forward"));
            footballTeam.AddPlayer(new Players("Ramirez", 24, 9, "forward"));

            foreach (var player in footballTeam)
            {
                Console.WriteLine($"#{player.Number}");
                Console.WriteLine(player);
            }

        }
    }
}