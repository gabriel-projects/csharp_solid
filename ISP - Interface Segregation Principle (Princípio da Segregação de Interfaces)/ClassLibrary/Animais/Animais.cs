using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Animais
{
    public class Animais
    {
        public Animais()
        {
            
        }
    }

    public interface IAve
    {
        void Bicar();
        void Voar();
    }


    public class Gaviao : IAve
    {
        public void Bicar()
        {
            //BICAR
        }

        public void Voar()
        {
            //VOAR
        }
    }

    public class Pinguin : IAve
    {
        public void Bicar()
        {
            //bicar
        }

        public void Voar()
        {
            //não faz sentido
        }
    }
}
