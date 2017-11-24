using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet101Bank
{
    public class Atm
    {
        public bool WithDraw(int money)
        {
            if (money == 0) return false;
            return (money % 5 == 0);
        }
    }
}
