using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    // Этот интерфейс определяет поведение "наличия вершин"
    public interface IPointy
    {
        // Член является неявно открытым и абстрактным.
        byte Points
        {
            get;
        }
    }
}
