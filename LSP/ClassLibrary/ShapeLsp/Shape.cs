using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ShapeLsp
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Desenhando uma forma genérica.");
        }
    }

    // Classe derivada, violando o LSP
    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Desenhando um quadrado.");
        }

        // Método específico do quadrado que viola o LSP adicionam comportamentos específicos que não estão presentes na classe base Shape.
        public void GetSideLength()
        {
            Console.WriteLine("Lado do quadrado: 5");
        }
    }

    public class Main
    {
        public Main()
        {
            Shape shape1 = new Shape();
            Shape shape2 = new Square();

            DrawShape(shape1); // Resultado: Desenhando uma forma genérica.
            DrawShape(shape2); // Resultado: Desenhando um quadrado.
        }


        // Função que utiliza a classe base e viola o LSP
        void DrawShape(Shape shape)
        {
            shape.Draw();
        }
    }
}
