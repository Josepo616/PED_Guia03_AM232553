using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;


namespace Guia_10_Grafos_Proc
{
internal class CArco
{
    // Atributos
    public int peso; //Peso (Valor) de cada arco (Arista)
    public float grosor_flecha; //indica grosor del arco
    public Color color;

    //objeto para referenciar elementos de la clase CVertice
    public CVertice nDestino;



        //Constructor con herencia para poder dar valor al arco 
        // dentro de la clase Cvertice
        public CArco(CVertice destino) : this(destino, 1)
        {
            this.nDestino = destino;
        }

        //Constructor con parametros para dar valores iniciales
        public CArco(CVertice destino, int peso)
        {
            this.nDestino = destino;
            this.peso = peso;
            this.grosor_flecha = 2;
            this.color = Color.Red;//color del arco
        }




    }


}
