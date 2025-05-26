using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.Generic;

namespace Guia_10_Grafos_Proc
{
    internal class CGrafo
    {
        //  Atributos
        public List<CVertice> nodos; // lista de nodos del grafo
        //  Metodos
        public CGrafo() // contructor de la clase
        {
            nodos = new List<CVertice>();
        }
        //  =====  Operaciones Basicas  ======
        //retorna cantidad de nodos almacenados
        public int TotalVertices { get => nodos.Count; }
        // Crea nodo a partir de su valor y lo agrega a la lista de nodos
        public CVertice AgregarVertice(string valor)
        {
            CVertice nodo = new CVertice(valor);
            nodos.Add(nodo);
            return nodo;
        }
        // Agrega nodo a la lista de nodos del grafo
        public void AgregarVertice(CVertice nuevonodo)
        {
            nodos.Add(nuevonodo);
        }
        // Busca un nodo en la lista de nodos del grafo
        public CVertice BuscarVertice(string valor)
        {
            return nodos.Find(v => v.Valor == valor);
        }
        // Crea arista a partir de los nodos de origen y de destino
        public bool AgregarArco(CVertice origen, CVertice nDestino, int peso = 1)
        {
            if (origen.ListaAdyacencia.Find(v => v.nDestino == nDestino) == null)
            {
                origen.ListaAdyacencia.Add(new CArco(nDestino, peso));
                return true;
            }
            return false;
        }
        // Crea arista a partir de valores de nodos (origen y destino)
        public bool AgregarArco(string origen, string nDestino, int peso = 1)
        {
            CVertice vOrigen, vnDestino;

            // si alguno de los nodos no existe, se activa una excepcion
            if ((vOrigen = nodos.Find(v => v.Valor == origen)) == null)
                throw new Exception("El nodo " + origen + " no existe dentro del grafo");
            if ((vnDestino = nodos.Find(v => v.Valor == nDestino)) == null)
                throw new Exception("El nodo " + nDestino + " no existe dentro del grafo");

            return AgregarArco(vOrigen, vnDestino);
        }
        // Metodos para dibujar el grafo
        //dibujar en el grafo
        public void DibujarGrafo(Graphics g)
        {
            //Dibuja los arcos
            foreach (CVertice nodo in nodos)
                nodo.DibujarArco(g);

            //Dibuja los vertices
            foreach (CVertice nodo in nodos)
                nodo.DibujarVertice(g);
        }
        public CVertice DetectarPunto(Point posicionMouse)
        {
            foreach (CVertice nodoActual in nodos)
                if (nodoActual.DetectarPunto(posicionMouse)) return nodoActual;
            return null;
        }
        public void ReestablecerGrafo(Graphics g)
        {
            foreach (CVertice nodo in nodos)
            {
                nodo.Color = Color.White;
                nodo.FontColor = Color.Black;
                foreach (CArco arco in nodo.ListaAdyacencia)
                {
                    arco.grosor_flecha = 1;
                    arco.color = Color.Black;
                }
            }
            DibujarGrafo(g);
        }
        //  Guia 11
        public void ColorArista(string o, string d)
        {
            foreach (CVertice nodo in nodos)
            {
                foreach (CArco a in nodo.ListaAdyacencia)
                {
                    if (nodo.ListaAdyacencia != null &&
                        nodo.Valor == o && a.nDestino.Valor == d)
                    {
                        a.color = Color.Red;
                        a.grosor_flecha = 4;
                    }
                }
            }
        }
        public CVertice NodoDistanciaMinima()
        {
            int min = int.MaxValue;
            CVertice temp = null;
            foreach (CVertice origen in nodos)
                if (origen.Visitado)
            foreach (CVertice destino in nodos)
                if (!destino.Visitado)
            foreach (CArco a in origen.ListaAdyacencia)
                if (a.nDestino == destino && min > a.peso)
                {
                    min = a.peso;
                    temp = destino;
                }
            return temp;
        }
        public int posicionNodo(string Nodo)
        {
            for (int i = 0; i < nodos.Count; i++)
                if (String.Compare(nodos[i].Valor, Nodo) == 0)
                    return i;
            return -1;
        }


        //Funcion para re-dibujar los arcos que llegan a un nodo
        public void DibujarEntrantes(CVertice nDestino)
        {
            foreach (CVertice nodo in nodos)
                foreach (CArco a in nodo.ListaAdyacencia)
                    if (nodo.ListaAdyacencia != null && nodo != nDestino)
                    {
                        if (a.nDestino == nDestino)
                        {
                            a.color = Color.Black;
                            a.grosor_flecha = 2;
                            break;
                        }
                    }
        }

        //funcion que desmarca como visitados todos los nodos del grafo
        public void Desmarcar()
        {
            foreach (CVertice n in nodos)
            {
                n.Visitado = false;
                n.Padre = null;
                n.distancianodo = int.MaxValue;
                n.pesoasignado = false;
            }
        }

        public List<CVertice> Dijkstra(CVertice origen, CVertice destino)
        {
            var distancias = new Dictionary<CVertice, int>();
            var anteriores = new Dictionary<CVertice, CVertice>();
            var nodos = new List<CVertice>();

            // Inicializamos distancias
            foreach (CVertice v in this.nodos)
            {
                distancias[v] = int.MaxValue;
                anteriores[v] = null;
                nodos.Add(v);
            }

            distancias[origen] = 0;

            while (nodos.Count > 0)
            {
                // Ordenar nodos por distancia más corta conocida
                nodos.Sort((x, y) => distancias[x] - distancias[y]);
                CVertice actual = nodos[0];
                nodos.Remove(actual);

                if (actual == destino)
                    break;

                foreach (CArco arco in actual.ListaAdyacencia)
                {
                    CVertice vecino = arco.nDestino;
                    int nuevaDistancia = distancias[actual] + arco.peso;
                    if (nuevaDistancia < distancias[vecino])
                    {
                        distancias[vecino] = nuevaDistancia;
                        anteriores[vecino] = actual;
                    }
                }
            }

            // Reconstruir el camino
            List<CVertice> ruta = new List<CVertice>();
            CVertice temp = destino;
            while (temp != null)
            {
                ruta.Insert(0, temp);
                temp = anteriores[temp];
            }

            return ruta;
        }

    }
}
