using System;
using System.Collections.Generic;
using System.Linq;
using FootballAPI.Models;

namespace FootballAPI.Data
{
    public class PlayerContext : IPlayerContext
    {

        private List<Player> _play;
        private readonly IPlayerContext _playerContext;

        public PlayerContext(PlayerContext playerContext)
        {
            _playerContext = playerContext;
            _play = new List<Player>()
            {
                new Player("Lionel Messi", 13, 175),
                new Player("Cristiano Ronaldo", 7, 185),
                new Player("Kylian Mbappe", 17, 178),
                new Player("Neymar Jr", 12, 179),
                new Player("Ilya Kireev", 1, 180),
            };
        }

        public IEnumerable<Player> GetAllPlayer()
        {
            return _play.Select(p => p).ToList();
        }

        public Player? GetPlayerById(int Id)
        {
            return _play.FirstOrDefault(p => p.ID == Id);
        }



        public Player? GetPlayerByNumber(int number)
        {
            return _play.FirstOrDefault(p => p.Number.Equals(number));
        }

        public Player? RemovePlayerById(int id)
        {
            var player = _play.FirstOrDefault(p => p.ID == id);
            if (player != default)
            {
                _play.Remove(player);
            }

            return player;
        }

        public Player AddPlayer(Player player)
        {
            throw new NotImplementedException();
        }
    }
}