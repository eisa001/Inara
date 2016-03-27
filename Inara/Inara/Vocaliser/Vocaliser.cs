using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocaliser
{
    public class Vocaliser :IVocaliser
    {
        public string Speaker(string message)
        {
            return message;
        }
    }
}
