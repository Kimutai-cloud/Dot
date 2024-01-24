using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        // Declare CurrentPlayer property with public access
        public Player CurrentPlayer { get; private set; }
        public Locations CurrentLocation { get; set; }

        public GameSession()
        {
           CurrentPlayer = new Player();
           CurrentPlayer.Name = "Kevin";
           CurrentPlayer.CharacterClass = "Mage";
           CurrentPlayer.HitPoints = 10;
           CurrentPlayer.Gold = 10000000;
           CurrentPlayer.ExperiencePoints = 0;
           CurrentPlayer.Level = 1;
           CurrentLocation = new Locations();
           CurrentLocation.Name = "Home";
           CurrentLocation.XCoordinate = 0;
           CurrentLocation.YCoordinate = -1;
           CurrentLocation.Description = "This is your house";
           CurrentLocation.ImageName = "/Engine;component/Components/Images/Locations/Home.png";
        }
    }
}
