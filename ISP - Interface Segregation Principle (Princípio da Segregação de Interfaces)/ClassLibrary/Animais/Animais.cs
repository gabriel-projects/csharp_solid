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
        //void Voar(); segregando a interface
    }


    public class Gaviao : IAveVoadora
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

        //Segregando a interface
        //public void Voar()
        //{
        //    //não faz sentido
        //}
    }

    public interface IAveVoadora : IAve
    {
        void Voar();
    }
}
