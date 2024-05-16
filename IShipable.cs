using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5_Maric
{
    public interface IShipable
    {
        double Price { get; }
        double Weight { get; }
        string Description(int depth = 0);
    }

}
