
using System.Runtime.ConstrainedExecution;

namespace ClassLibrary.Renderer
{
    //Nesse exemplo, temos uma classe abstrata Shape que define um contrato para desenhar formas geométricas. As classes Circle e Square estendem a classe abstrata Shape e implementam sua própria lógica para desenhar um círculo e um quadrado, respectivamente.

    //A classe Renderer é responsável por renderizar uma lista de formas geométricas.Ela não precisa ser modificada quando uma nova forma é adicionada ao sistema, pois utiliza o polimorfismo para chamar o método Draw() de cada forma, independentemente de qual seja. Isso permite que novas formas sejam adicionadas ao sistema sem a necessidade de modificar o código existente.

    //Em ambos os exemplos, o princípio do OCP é aplicado ao permitir que o sistema seja estendido para novos comportamentos sem modificar o código existente. Isso torna o software mais flexível, facilita a manutenção e reduz o risco de introduzir erros ao realizar modificações em partes já funcionais do sistema.
    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            // Lógica para desenhar um círculo
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            // Lógica para desenhar um quadrado
        }
    }

    public class Renderer
    {
        public void RenderShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }

}
