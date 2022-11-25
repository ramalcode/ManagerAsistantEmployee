using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Moduls
{
    internal class Asistant:Manager
    {
        
        public void GetFeedBack(Emplyee emplyee)
        {
            if (emplyee.IsSuccesfull)
            {
                GetPromotion(emplyee);
            }
            else
            {
                Console.WriteLine("Uzerinde biraz da chalish.");
            }
        }
    }
}
