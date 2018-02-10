using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    // Абстрактный базовый класс иерархии.
   abstract class Shape
    {
       /* Вынудить все дочерние классы определить свою визуализацию.
       public abstract void Draw();*/
       public Shape(string name = "NoName")
       {
           PetName = name;
       }
       public string PetName
       {
           get;
           set;
       }
       // Единственный виртуальный метод.
       public virtual void Draw()
       {
           Console.WriteLine("Inside Shape.Draw()");
       }

       /*// Каждый производный класс должен теперь поддерживать этот метод!
       public abstract byte GetNumberOfPoints();*/
    }
}
