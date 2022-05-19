using System;
using System.ComponentModel.DataAnnotations;
namespace FootballAPI.Models
{
    public class Player
    {
        private static int idstat = 0;
        public Player(string name, int number, int height)
        {
            ID = ++idstat;
            Name = name;
            Number = number;
            Hieght =height ;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public int Hieght { get; set; }
    }
}