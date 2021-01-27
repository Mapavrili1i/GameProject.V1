using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
  

        public void Add(Campaign campaign,Game game,Gamer gamer)
        {
            Console.WriteLine("Campaing: "+campaign.CampaignName +" added for Game: "+game.GameName+" for Customer: "+gamer.FirstName+" " +gamer.LastName);
        }

        public void Delete(Campaign campaign, Game game, Gamer gamer)
        {
            Console.WriteLine("Campaing: " + campaign.CampaignName + " added for Game: " + game.GameName + " for Customer: " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Campaign campaign, Game game, Gamer gamer)
        {
            Console.WriteLine("Campaing: " + campaign.CampaignName + " added for Game: " + game.GameName + " for Customer: " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
