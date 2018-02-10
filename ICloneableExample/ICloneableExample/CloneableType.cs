using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableExample
{
    public abstract class CloneableType
    {
        // Только производные типы могут поддерживать этот
        // "полиморфный интерфейс". Классы в других иерархиях
        // не имеют доступа к этому абстрактному члену.
        public abstract object Clone();
    }
}
