using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewels
{
    internal class Owner
    {
        private Jewels returnContents;
        public void ReceiveContents(Jewels saveContents)
        {
            returnContents = saveContents;
            Console.WriteLine("Dziękuję za zwrócenie klejnotów! " + saveContents.Sparkle());
        }
    }
}
