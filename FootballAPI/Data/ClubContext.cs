using System;
using System.Collections.Generic;
using System.Linq;
using FootballAPI.Models;

namespace FootballAPI.Data
{
    public class ClubContext: IClubContext
    {
        private List<Club> _club;
        private readonly IClubContext _clubContext;
        public ClubContext (ClubContext clubContext)
        {
            _clubContext = clubContext;
            _club = new List<Club>()
            {
                new Club("Zenit",1925, 22),
                new Club("CSKA",1911, 23),
                new Club("RealMadrid",1902, 24),
                new Club("Barcelona",1899, 24),
                new Club("Dinamo",1923, 22),
            };
        }

        public IEnumerable<Club> GetAllClub()
        {
            return _club.Select(c => c).ToList();
        }

        

        public Club? GetClubById(int Id)
        {
            return _club.FirstOrDefault(p => p.ID == Id);
        }

            

        public Club? GetClubByTitle(string Title)
        {
            return _club.FirstOrDefault(c => c.Title.Equals(Title));
        }

        public Club? RemoveClubById(int id)
        {
            var club = _club.FirstOrDefault(c => c.ID == id);
            if (club != default)
            {
                _club.Remove(club);
            }
            return club;
        }

        public Club AddClub(Club club)
        {
            throw new NotImplementedException();
        }
    }
}