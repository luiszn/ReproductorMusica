using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ReproductorMusica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsListaCircular ld = new clsListaCircular();
            clsCanciones c1= new clsCanciones();
            c1.nombre="Cant tell me nothing";
            c1.artista="Kanye West";
            c1.ubicacion="1.wav";
            clsCanciones c2 = new clsCanciones();
            c2.nombre="Fair Tade";
            c2.artista="Drake";
            c2.ubicacion="2.wav";
            clsCanciones c3 = new clsCanciones();
            c3.nombre="Malas intenciones";
            c3.artista="Heroes del silencio";
            c3.ubicacion="3.wav";
            ld.Insertar(c1);
            ld.Insertar(c2);
            ld.Insertar(c3);
            ld.Navegar();
            Console.ReadKey();
        }
    }
}
