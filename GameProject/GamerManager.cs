using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kişi Başarıyla Eklenmiştir.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kişi Başarıyla Silinmiştir.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kişi Başarıyla Güncellenmiştir.");
        }
    }
}
