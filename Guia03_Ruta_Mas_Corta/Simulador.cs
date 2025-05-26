using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Configuration;


//guia 11:
using System.Threading;


namespace Guia_10_Grafos_Proc
{
    public partial class Simulador : Form
    {


//instancias de las clases de esta solucion:
CGrafo grafo;
CVertice nuevoNodo;
CVertice NodoOrigen;
CVertice NodoDestino;
Vertice ventanaVertice;
//determina el estado de nodo en la pizarra:
// 0: sin accion, 1: dibujando arco, 2: nuevo vertice
int var_control = 0;


        //Guia 11:

//private Recorrido ventanaRecorrido; // ventana para seleccionar el nodo inicial del recorrido
private Arco ventanaArco; // ventana para agregar los arcos
List<CVertice> nodosRuta; // Lista de nodos utilizada para almacenar la ruta
List<CVertice> nodosOrdenados; // Lista de nodos ordenadas a partir del nodo origen
Queue<CVertice> cola; //para el recorrido de anchura
bool buscarRuta = false, nuevoVertice = false, nuevoArco = false;
bool profundidad = false, anchura = false, nodoEncontrado = false;
private string destino = "", origen = "";
private int distancia = 0;
int[] parent; // padre del nodo
bool[] visitados; // variable para comprobar los nodos ya visitados



        public void OrdenarNodos()
        {
            nodosOrdenados = new List<CVertice>();
            bool est = false;
            foreach (CVertice nodo in grafo.nodos)            
                if (nodo.Valor == origen)
                {
                    nodosOrdenados.Add(nodo);
                    est = true;
                }
                else if (est)
                    nodosOrdenados.Add(nodo);
            
            foreach (CVertice nodo in grafo.nodos)
                if (nodo.Valor == origen)
                {
                    est = false;
                    break;
                }
                else if (est)
                    nodosOrdenados.Add(nodo); 
}

private void RecorridoProfundidad(CVertice vertice, Graphics g)
{
    vertice.Visitado = true;
    vertice.Colorear(g);
    lstRecorrido.Items.Add(vertice.Valor);
    lstRecorrido.Refresh();
    Thread.Sleep(2000);
    foreach (CArco adya in vertice.ListaAdyacencia)
        if (!adya.nDestino.Visitado) 
            RecorridoProfundidad(adya.nDestino, g);
}

private void recorridoAnchura(CVertice vertice, Graphics g, string destino)
{
    vertice.Visitado = true;
    cola.Enqueue(vertice);
    vertice.Colorear(g);
    lstRecorrido.Items.Add(vertice.Valor);
    lstRecorrido.Refresh();
    Thread.Sleep(2000);
    if (vertice.Valor == destino)
    {
        nodoEncontrado = true;
        return;
    }
    while (cola.Count > 0)
    {
        CVertice aux = cola.Dequeue();
        foreach (CArco adya in aux.ListaAdyacencia)
            if (!adya.nDestino.Visitado)
                if (!nodoEncontrado)
                {
                    adya.nDestino.Visitado = true;
                    adya.nDestino.Colorear(g);
                    lstRecorrido.Items.Add(adya.nDestino.Valor);
                    lstRecorrido.Refresh();
                    Thread.Sleep(1000);
                    if (destino != "")
                        distancia += adya.peso;
                    cola.Enqueue(adya.nDestino);
                    if (adya.nDestino.Valor == destino)
                    {
                        nodoEncontrado = true;
                        return;
                    }
                }
    }
}












            public Simulador()
{
    InitializeComponent();
    grafo = new CGrafo();
    nuevoNodo = null;
    var_control = 0;
    ventanaVertice = new Vertice();
    this.SetStyle(ControlStyles.AllPaintingInWmPaint| ControlStyles.UserPaint |
    ControlStyles.DoubleBuffer, true);



ventanaArco = new Arco();
nodosRuta = new List<CVertice>();
nodosOrdenados = new List<CVertice>();
cola = new Queue<CVertice>();


        }







private void ActualizarVertices()
{
    CBVertice.Items.Clear();
    CBVertice.SelectedIndex = -1;
    CBNodoPartida.Items.Clear();
    foreach (CVertice nodo in grafo.nodos)
    {
        CBVertice.Items.Add(nodo.Valor);
        CBNodoPartida.Items.Add(nodo.Valor);
    }

}

private void ActualizarArcos()
{
    CBArco.Items.Clear();
    CBArco.SelectedIndex = -1;
    foreach (CVertice nodo in grafo.nodos)
    {                
        foreach (CArco arco in nodo.ListaAdyacencia)
            CBArco.Items.Add("(" + nodo.Valor + "," + arco.nDestino.Valor +
                ") peso: " + arco.peso);
    }

}





        private void pizarra_Paint(object sender, PaintEventArgs e)
{
    try
    {
        //e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
        //grafo.DibujarGrafo(e.Graphics);




                //Guia 11:

e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
grafo.DibujarGrafo(e.Graphics);

if (buscarRuta)
{
    foreach (CVertice nodo in nodosRuta)
    {
        nodo.Colorear(e.Graphics);
        Thread.Sleep(1000);
        nodo.DibujarVertice(e.Graphics);
    }
    buscarRuta = false;
}

if (profundidad)
{
    //ordenando los nodos desde el que indica el usuario
    OrdenarNodos();
    lstRecorrido.Items.Clear();
    lstRecorrido.Items.Add("Nodo inicial: " + CBNodoPartida.Text);
    lstRecorrido.Refresh();

    foreach (CVertice nodo in nodosOrdenados)
        if (!nodo.Visitado)
            RecorridoProfundidad(nodo, e.Graphics);
    
    profundidad = false;
    //reestablecer los valores
    foreach (CVertice nodo in grafo.nodos)
        nodo.Visitado = false;

    MessageBox.Show("Se finalizo recorrido en profundidad del Grafo", 
        "Gestion de Grafos", MessageBoxButtons.OK,MessageBoxIcon.Information);
    Pizarra.Refresh();
}
if (anchura)
{
    distancia = 0;
    //ordenando los nodos desde el que indica el usuario
    cola = new Queue<CVertice>();
    OrdenarNodos();
    lstRecorrido.Items.Clear();
    lstRecorrido.Items.Add("Nodo inicial: " + CBNodoPartida.Text);
    lstRecorrido.Refresh();

    foreach (CVertice nodo in nodosOrdenados)
        if (!nodo.Visitado && !nodoEncontrado)
            recorridoAnchura(nodo, e.Graphics, destino);
    
    anchura = false;
    nodoEncontrado = false;
    //reestablecer los valores
    foreach (CVertice nodo in grafo.nodos)
        nodo.Visitado = false;

    MessageBox.Show("Se finalizo recorrido en anchura/amplitud del Grafo",
    "Gestion de Grafos", MessageBoxButtons.OK, MessageBoxIcon.Information);
    Pizarra.Refresh();

}

            }
            catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }

}




        private void BtnEliminarVer_Click(object sender, EventArgs e)
        {

if (CBVertice.SelectedIndex > -1)
{
    foreach (CVertice nodo in grafo.nodos)
        if (nodo.Valor == CBVertice.SelectedItem.ToString())
        {
            grafo.nodos.Remove(nodo);
            //Borrando arcos que posea el nodo eliminado
            nodo.ListaAdyacencia = new List<CArco>();
            break;
        }
    
    foreach (CVertice nodo in grafo.nodos)
        foreach (CArco arco in nodo.ListaAdyacencia)
            if (arco.nDestino.Valor == CBVertice.SelectedItem.ToString())
            {
                nodo.ListaAdyacencia.Remove(arco);
                break;
            }

    ActualizarVertices();
    ActualizarArcos();

    nuevoArco = true;
    nuevoVertice = true;
    CBVertice.SelectedIndex = -1;
    Pizarra.Refresh();
}
else
{
    MessageBox.Show("Primero debe seleccionar un Vertice",
        "Gestion de Nodos: borrar Vertice", MessageBoxButtons.OK,
        MessageBoxIcon.Error);
    CBVertice.Focus();
}

        }




        private void BtnElArc_Click(object sender, EventArgs e)
        {

if (CBArco.SelectedIndex > -1)
{
    string arcoelegido = CBArco.SelectedItem.ToString();
    foreach (CVertice nodo in grafo.nodos)
        foreach (CArco arco in nodo.ListaAdyacencia)
            if ("(" + nodo.Valor + "," + arco.nDestino.Valor +
                ") peso: " + arco.peso == arcoelegido)
            {
                nodo.ListaAdyacencia.Remove(arco);
                ActualizarVertices();
                ActualizarArcos();
                break;
            }
    
    nuevoVertice = true;
    nuevoArco = true;
    CBArco.SelectedIndex = -1;
    Pizarra.Refresh();
}
else
    MessageBox.Show("Primero debe elegir un Arco del listado",
        "Gestion de Nodos: borrar Arco entre Vertices", MessageBoxButtons.OK,
        MessageBoxIcon.Error);

        }

        private void BtnProf_Click(object sender, EventArgs e)
        {

if (CBNodoPartida.SelectedIndex > -1)
{
    profundidad = true;
    origen = CBNodoPartida.SelectedItem.ToString();
    Pizarra.Refresh();
    CBNodoPartida.SelectedIndex = -1;
}
else
{
    MessageBox.Show("Debe seleccionar un Vertice de Partida para el Recorrido",
        "Gestion de Nodos: Recorrido de Vertices", MessageBoxButtons.OK,
        MessageBoxIcon.Error);
    CBNodoPartida.Focus();
}

        }




        private void BtnAnch_Click(object sender, EventArgs e)
        {
if (CBNodoPartida.SelectedIndex > -1)
{
    origen = CBNodoPartida.SelectedItem.ToString();
    anchura = true;
    Pizarra.Refresh();
    CBNodoPartida.SelectedIndex = -1;
}
else
    MessageBox.Show("Debe seleccionar un Vertice de Partida para el Recorrido",
        "Gestion de Nodos: Recorrido de Vertices", MessageBoxButtons.OK,
        MessageBoxIcon.Error);
    CBNodoPartida.Focus();



        }



        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CVertice verticeB;
            if (txtBuscar.Text.Trim() != "")
            {
                verticeB = grafo.BuscarVertice(txtBuscar.Text);
                if (verticeB != null)
                {
                    verticeB.Colorear(Pizarra.CreateGraphics());
                    Thread.Sleep(1000);
                    verticeB.DibujarVertice(Pizarra.CreateGraphics());
                    txtBuscar.Clear();
                    txtBuscar.Focus();
                }
                else
                    MessageBox.Show("No se encuentra el vertice " + txtBuscar.Text,
                        "Gestion de Grafos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bntRutaCorta_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "" || txtDestino.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar tanto el nodo origen como el destino.",
                    "Ruta más corta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CVertice origen = grafo.BuscarVertice(txtBuscar.Text);
            CVertice destino = grafo.BuscarVertice(txtDestino.Text);

            if (origen == null || destino == null)
            {
                MessageBox.Show("Uno o ambos vértices no existen en el grafo.",
                    "Ruta más corta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<CVertice> ruta = grafo.Dijkstra(origen, destino);

            if (ruta.Count == 0 || ruta[0] != origen)
            {
                MessageBox.Show("No existe ruta entre los vértices seleccionados.",
                    "Ruta más corta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Graphics g = Pizarra.CreateGraphics();
            foreach (CVertice v in ruta)
            {
                v.Colorear(g);
                Thread.Sleep(500); // Para visualización
                v.DibujarVertice(g);
            }

            MessageBox.Show("Ruta más corta resaltada correctamente.",
                "Ruta más corta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBuscar.Clear();
            txtDestino.Clear();
        }


        private void pizarra_MouseLeave(object sender, EventArgs e)
{
    Pizarra.Refresh();
}

        




private void nuevoVérticeToolStripMenuItem_Click(object sender, EventArgs e)
{
    nuevoNodo = new CVertice();
    //Se usa para indicar el estado en la pizarra:
    //0: sin accion, 1: dibujando arco, 2: nuevo vertice
    var_control = 2;
}



private void pizarra_MouseDown(object sender, MouseEventArgs e)
{
    //si se ha presionado el boton secundario del mouse
    if (e.Button == MouseButtons.Right)
    {
        switch (var_control)
        {
            case 0:
                NodoOrigen = grafo.DetectarPunto(e.Location);
                if (NodoOrigen != null)                        
                    MessageBox.Show("Nodo " + NodoOrigen.Valor.ToString(),
                        "Nodo existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                        
                else
                    Pizarra.ContextMenuStrip = this.CMSCrearVertice;

                break;
        }
    }
                        
    //si presiona boton primario del mouse
    if (e.Button == MouseButtons.Left)
    {   
        //recuerde que es usado para indicar estado en pizarra:
        //0: sin accion, 1: dibujando arco, 2: nuevo vertice
        switch (var_control)
        {
            case 0:
                //si existe nodo origen, intenta crear un arco hacia un nodo destino
                NodoOrigen = grafo.DetectarPunto(e.Location);
                if (NodoOrigen!=null)
                    var_control = 1;

                break;
            case 1:
                //intenta completar arco
                NodoDestino = grafo.DetectarPunto(e.Location);
                //si existe nodo destino, evalua si sera un arco valido (nodos distintos)
                if (NodoDestino != null)
                {
                    if(NodoOrigen != NodoDestino)
                    {
                        if (grafo.AgregarArco(NodoOrigen, NodoDestino))
                        {
                            //procede a crear la arista
                            int distancia = 0;
                            NodoOrigen.ListaAdyacencia.Find(v => v.nDestino == NodoDestino).peso = distancia;
                        }
                    }
                }
                NodoOrigen = null;
                NodoDestino = null;
                var_control = 0;
                Pizarra.Refresh();

                break;
            case 2:                        
                //si coordenadas no coinciden con un nodo existente, solicita su valor a usuario
                if (grafo.DetectarPunto(e.Location) == null)
                {
                    ventanaVertice.Visible = false;
                    ventanaVertice.control = false;

                    ventanaVertice.ShowDialog();
                    if (ventanaVertice.control)
                    {
                        string valorvertice = ventanaVertice.txtVertice.Text.Trim();
                        if (valorvertice.Length > 0 && grafo.BuscarVertice(valorvertice) == null)
                        {
                            nuevoNodo.Valor = ventanaVertice.txtVertice.Text;
                            grafo.AgregarVertice(nuevoNodo);
                            ActualizarVertices();
                            ActualizarArcos();
                        }
                        else
                            MessageBox.Show("El Nodo " + ventanaVertice.txtVertice.Text +
                                " ya existe en el grafo", "Error al crear Nodo", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                    }
                    nuevoNodo = null;
                    var_control = 0;
                    Pizarra.Refresh();
                }
                break;
        }
    }

}


private void pizarra_MouseUp(object sender, MouseEventArgs e)
{
    switch (var_control)
    {

                /*
        case 1: //dibujando arco

            
            if ((NodoDestino = grafo.DetectarPunto(e.Location)) != null && 
                NodoOrigen != NodoDestino)
            {
                if (grafo.AgregarArco(NodoOrigen, NodoDestino))
                {
                    //procede a crear la arista
                    int distancia = 0;
                    NodoOrigen.ListaAdyacencia.Find(
                        v => v.nDestino == NodoDestino).peso = distancia;
                }
            }
            var_control = 0;
            NodoOrigen = null;
            NodoDestino = null;
            Pizarra.Refresh();
            */



                //Guia 11

case 1:
    if ((NodoDestino = grafo.DetectarPunto(e.Location)) != null && 
        NodoOrigen != NodoDestino)
    {
        ventanaArco.Visible = false;
        ventanaArco.control = false;
        ventanaArco.ShowDialog();
        if (ventanaArco.control)
        {
            if (grafo.AgregarArco(NodoOrigen, NodoDestino, ventanaArco.dato))
            {
                //Se procede a crear la arista
                int distancia = ventanaArco.dato;
                NodoOrigen.ListaAdyacencia.Find(
                    v => v.nDestino == NodoDestino).peso = distancia;

                ActualizarArcos();
            }
            nuevoArco = true;
        }
    }
    var_control = 0;
    NodoOrigen = null;
    NodoDestino = null;
    Pizarra.Refresh();

    break;

    }

}

private void pizarra_MouseMove(object sender, MouseEventArgs e)
{
    switch (var_control)
    {
        case 2: //ubicando a un nuevo nodo
            if(nuevoNodo!=null)
            {
                int posX = e.Location.X;
                int posY = e.Location.Y;

                if (posX < nuevoNodo.Dimensiones.Width / 2)
                    posX = nuevoNodo.Dimensiones.Width / 2;
                else 
                    if(posX>Pizarra.Size.Width-nuevoNodo.Dimensiones.Width/2)
                        posX = Pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2;

                if (posY < nuevoNodo.Dimensiones.Height / 2)
                    posX = nuevoNodo.Dimensiones.Height / 2;
                else
                    if (posY > Pizarra.Size.Height - nuevoNodo.Dimensiones.Width / 2)
                        posY = Pizarra.Size.Height - nuevoNodo.Dimensiones.Width / 2;

                nuevoNodo.Posicion = new Point(posX, posY);
                Pizarra.Refresh();
                nuevoNodo.DibujarVertice(Pizarra.CreateGraphics());
            }
            break;
        case 1: //dibujar arco
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4, true);
            bigArrow.BaseCap = System.Drawing.Drawing2D.LineCap.Triangle;

            Pizarra.Refresh();
            Pizarra.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2)
            {
                CustomEndCap = bigArrow
            },
            NodoOrigen.Posicion, e.Location);
            break;
    }
}

    }    

}
