using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_10_Grafos_Proc
{
    internal class CVertice
    {
//     Atributos
public string Valor;
public List<CArco> ListaAdyacencia;
Dictionary<string, short> _banderas;
Dictionary<string, short> _banderas_predeterminado;

static int size = 35;
Size dimensiones;
Color color_nodo;
Color color_fuente;
Point _posicion;
int radio;



        //Guia 11, paso 1
public int distancianodo;//guarda la distancia que hay entre el nodo inicio en el algoritmo de Dijkstra
public Boolean Visitado;//variable que sirve para marcar como visto el nodo en un recorrido
public CVertice Padre;//nodo que sirve en los recorridos como el antecesor
public Boolean pesoasignado;//variable que sirve se usa en el algoritmo de Dijkstra






        //    Metodos

        //Metodos de Propiedad

        public Color Color
{
    get { return color_nodo; }
    set { color_nodo = value; }
}
public Color FontColor
{
    get { return color_fuente; }
    set { color_fuente = value; }
}
public Point Posicion
{
    get { return _posicion; }
    set { _posicion = value; }
}
public Size Dimensiones
{
    get { return dimensiones; }
    set
    {
        radio = value.Width / 2;
        dimensiones = value;
    }
}


//Metodos constructores

public CVertice(string valor)
{
    Valor = valor;

    ListaAdyacencia = new List<CArco>();
    _banderas = new Dictionary<string, short>();
    _banderas_predeterminado = new Dictionary<string, short>();

    //acerca de presentacion de los nodos:
    Color = Color.Green; //define color de fondo            
    Dimensiones = new Size(size, size); // diametro del circulo            
    FontColor = Color.White; //color de fuente

//Guia 11            
    Visitado = false;
}

public CVertice() : this("") { }//constructor por defecto


//metodo para dibujar el Nodo
public void DibujarVertice(Graphics g)
{
    SolidBrush b = new SolidBrush(this.color_nodo);

    //determina coordenadas para ubicar a nodo
    Rectangle areaNodo = new Rectangle(this._posicion.X - radio,
        this._posicion.Y - radio, this.dimensiones.Width,
        this.dimensiones.Height);

    g.FillEllipse(b, areaNodo);
    g.DrawString(this.Valor, new Font("Times New Roman", 14),
        new SolidBrush(color_fuente), this._posicion.X, this._posicion.Y,
        new StringFormat()
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        }
        );
    g.DrawEllipse(new Pen(Brushes.Black, (float)1.0), areaNodo);
    b.Dispose(); //libera recursos usados por objeto
}

        public void Colorear(Graphics g)
        {
            SolidBrush b = new SolidBrush(Color.Gold);
            // Definimos donde dibujaremos el nodo
            Rectangle areaNodo = new Rectangle(this.Posicion.X - radio, 
                this.Posicion.Y - radio, this.dimensiones.Width, 
                this.dimensiones.Height);
            g.FillEllipse(b, areaNodo);
            g.DrawString(this.Valor, new Font("Times New Roman", 14), 
                new SolidBrush(Color.Black), this.Posicion.X, this.Posicion.Y, 
                new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });
            g.DrawEllipse(new Pen(Brushes.Black, (float)1.0), areaNodo);
            b.Dispose();
        }




        //metodo para dibujar los arcos
        public void DibujarArco(Graphics g)
{
    float distancia;
    int difY, difX;
    foreach (CArco arco in ListaAdyacencia)
    {
        difX = this.Posicion.X - arco.nDestino.Posicion.X;
        difY = this.Posicion.Y - arco.nDestino.Posicion.Y;
        distancia = (float)Math.Sqrt(Math.Pow(difX, 2) + Math.Pow(difY, 2));

        AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4, true);
        bigArrow.BaseCap = System.Drawing.Drawing2D.LineCap.Triangle;

        g.DrawLine(
            new Pen(new SolidBrush(arco.color), arco.grosor_flecha)
            {
                CustomEndCap = bigArrow,
                Alignment = PenAlignment.Center
            },
            _posicion,
            new Point(arco.nDestino.Posicion.X + (int)(radio * difX / distancia),
            arco.nDestino.Posicion.Y + (int)(radio * difY / distancia)));

        g.DrawString(
            arco.peso.ToString(),
            new Font("Times New Roman", 12, FontStyle.Bold),
            new SolidBrush(Color.Blue),
            this._posicion.X - (int)(difX / 3),
            this._posicion.Y - (int)(difY / 3),
            new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Far
            });
    }
}

public bool DetectarPunto(Point p)
{
    GraphicsPath posicion = new GraphicsPath();
    posicion.AddEllipse(
        new Rectangle(this._posicion.X - 2 * this.dimensiones.Width,
        this._posicion.Y - 2 * this.dimensiones.Height,
        this.dimensiones.Width*4, this.dimensiones.Height*4)
    );


    bool retval = posicion.IsVisible(p);
    posicion.Dispose();
    return retval;
}

public override string ToString()
{
    return this.Valor;
}














    }
}
