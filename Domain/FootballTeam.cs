using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HomeWork8.Domain
{
    internal class FootballTeam 
    {
        public SortedList<int, Players> _players = new SortedList<int, Players>();

        public string FootballTeamName { get; set; }

        public FootballTeam(string footballTeamName)
        {
            FootballTeamName = footballTeamName;
        }

        public void AddPlayer(Players player)
        {
            _players.Add(player.Number, player);
        }

        public void RemovePlayer(int numberPlayer)
        {
            _players.Remove(numberPlayer);
        }
        public IEnumerator<Players> GetEnumerator()
        {
            foreach (var player in _players)
            {
                yield return player.Value;
            }
        }
        public override string ToString()
        {
            return $"FootballTeamName: {FootballTeamName}";
        }
    }
}
