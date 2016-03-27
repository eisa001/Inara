using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inara.Memory.Established 
{
    public class EstablishedMemories :IEstablishedMemories
    {
        string myName;

        public void setName(string name)
        {
            myName = name;
        }

        public string getName()
        {
            return myName;
        }
    }
}
