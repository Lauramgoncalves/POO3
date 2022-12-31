using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    class Program
    {
        static void Main(string[] args)
        { /* Interface no CSHARP ela promove um contrato com a classe, se não seguir dá erro.
           * em interface tudo é publico
           * Não se pode colocar lógica.
           * Pode ter uantas interfaces uiser,
           * é bom pra usar Quando tem muitas opcoes.
           * Serve para organizar o código
           * Na interface não dá pra definir atributos. */

              IntDesenho shape = new Line(); //-> interface
            shape.Desenho();// -> Interface




            Desenho shapeabs = new Rect();// -> classe abstrata
            shapeabs.Des();  // -> class abstrata
            Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine();
        }
    }
    interface IntDesenho
    {
        void Desenho();       // <-Metodo
        float Area();

    }

    class Line : IntDesenho  // A classe Line segue o contrato "IDesenho"
    {
        public float Area()
        {
            return 20;
        }

        public void Desenho()
        {
            Console.WriteLine("Linha");
        }
    }
    class Quad : IntDesenho
    {
        public float Area()
        {
            return 2;
        }

        public void Desenho()
        {
            Console.WriteLine("Quad");
        }
    }
    class Rect : Desenho // Classe abstrata
    {
   

        public override float Area()
        {
            return 10;
        }

        public override void Des()
        {
            Console.WriteLine("Rect");
        }

     
    }





    /* Classes abstratas 
      * Não se pode instanciar uma classe abstrata
      * uando se define os metodos, tem ue implementar
      * Para não implementar colocar na frente do metodo "Public Abstract"
      *Na interface dá pra definir atributos.
      * uando se coloca uma classe abstrata do lado da classe filha, cria-se um sistema de herança.
      */

 

    abstract class Desenho
    {
        public int size; 
        public int cor;
        public abstract void Des();

        public abstract float Area();




    }
}