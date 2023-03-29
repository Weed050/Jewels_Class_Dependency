using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewels
{
    internal class Locksmith
    {
        public void OpenSafe(Safe safe,Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writeDownCombination);
            ReturnContents(safeContents, owner);
        }
        private string writeDownCombination = null;
        public void WriteDownCombination(string combination)
        {
            writeDownCombination = combination;
        }
        public void ReturnContents(Jewels safeContents,Owner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }
}
