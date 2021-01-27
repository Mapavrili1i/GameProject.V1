using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FirstName = "OSMAN",
                LastName = "ÖZKAN",
                BirthYear = 1995,
                IdentityNumber = 123456
            };
            Game game1 = new Game() 
            { 
                GameId = 0001, 
                GameName = "Tetris", 
                GamePrice =10 
            };
            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                CampaignName="Student",
                CampaignRate=50
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1, game1, gamer1);



        }
    }
}
