using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Add(Campaign campaign,Game game, Gamer gamer);
        void Update(Campaign campaign,Game game, Gamer gamer);
        void Delete(Campaign campaign,Game game, Gamer gamer); 

    }
}
