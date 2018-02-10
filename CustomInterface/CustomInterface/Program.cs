using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Interfaces *****\n");
            // Создать массив элементов Shape.
            Shape[] myShapes = {
                                   new Hexagon(), new Circle(),
                                   new Triangle("Joe"), new Circle("JoJo")
                               };
            for(int i=0; i< myShapes.Length; i++)
            {
                // Вспомните, что базовый класс Shape определяет абстрактный
                // член Draw(), поэтому все фигуры знают, как себя рисовать.
                myShapes[i].Draw();

                // У всех фигур есть вершины?
                if (myShapes[i] is IPointy)
                {
                    Console.WriteLine("-> Points: {0}", ((IPointy) myShapes[i]).Points);
                }else{
                    Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);
                    Console.WriteLine();
                }
            }
            /*// Вызывает свойствоPoints, определенное интерфейсом IPointy.
            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);

            // Перехватить возможность исключение InvalidCastException.
            Circle c = new Circle("Lisa");
            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            // Можно ли hex2 интерпритировать как IPointy?
            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;

            if (itfPt2 != null){
             Console.WriteLine("Points: {0}", itfPt2.Points);
            }
            else
            {
                Console.WriteLine("OOPS! Not pointy...");
            }*/
            Console.ReadLine();
        }
    }
}
