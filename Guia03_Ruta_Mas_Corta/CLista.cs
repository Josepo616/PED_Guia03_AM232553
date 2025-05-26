using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System.Collections.Generic;


namespace Guia_10_Grafos_Proc
{
    internal class CLista
    {

//    Atributos

//Objetos privados para instanciar elementos de las otras clases
private CVertice aElemento;
private CLista aSubLista;
private int aPeso; //peso de los arcos

//Constructor
public CLista()
{
    aElemento = null;
    aSubLista = null;
    aPeso = 0;
}

//Sobrecarga del Constructor
public CLista(CLista pLista)
{
    if (pLista != null)
    {
        aElemento = pLista.aElemento;
        aSubLista = pLista.aSubLista;
        aPeso = pLista.aPeso;
    }
}

//Sobrecarga 2 de Constructor para agregar valores al nodo
//con su peso que es cero por defecto 
public CLista(CVertice pElemento, CLista pSubLista, int pPeso)
{
    aElemento = pElemento;
    aSubLista = pSubLista;
    aPeso = pPeso;
}

//  Propiedades
public CVertice Elemento //propiedad de tipo Cvertice 
{
    get { return aElemento; }
    set { aElemento = value; }
}

public CLista SubLista//propiedad de tipo CLista
{
    get { return aSubLista; }
    set { aSubLista = value; }
}

public int Peso//Propiedad para el peso del nodo
{
    get { return aPeso; }
    set { aPeso = value; }
}
//metodo que verifica si la lista esta vacia
public bool EsVacia()
{
    return aElemento == null;
}

public void Agregar(CVertice pElemento, int pPeso)//Método para agregar nodo
{
    if (pElemento != null)
    {
        if (aElemento == null)
        {
            aElemento = new CVertice(pElemento.Valor);
            aPeso = pPeso;
            aSubLista = new CLista();
        }
        else if (!ExisteElemento(pElemento))
        {
            aSubLista.Agregar(pElemento, Peso);
        }
    }
}

public void Eliminar(CVertice pElemento)//Método para eliminar nodo
{
    if (aElemento != null)//Si existe un elemento
    {
        //Si elemento que se solicita como parametro es igual al elemento ya existente
        if (aElemento.Equals(pElemento))
        {
            aElemento = aSubLista.aElemento;
            aSubLista = aSubLista.SubLista;//se guarda en la sublista
        }
        else
        {
            aSubLista.Eliminar(pElemento);//se elimina el elemento
        }
    }
}

public int NroElementos()//devuelve el numero de elementos
{
    if (aElemento != null)
        return 1 + aSubLista.NroElementos();
    else
        return 0;
}

//retorna el elemento de la posicion solicitada
public object lesimoElemento(int posicion)
{
    if ((posicion > 0) && (posicion <= NroElementos()))
    {
        if (posicion == 1)
            return aElemento;
        else
            return aSubLista.lesimoElemento(posicion - 1);
    }
    else
        return 0;
}

//retorna el peso de la posicion solicitada
public object lesimoElementoPeso(int posicion)
{
    if ((posicion > 0) && (posicion <= NroElementos()))
    {
        if (posicion == 1)
            return aPeso;
        else
            return aSubLista.lesimoElementoPeso(posicion - 1);
    }
    else
        return 0;
}

//Retorna si existe o no el elemento solicitado como parametro
public bool ExisteElemento(CVertice pElemento)
{
    if (aElemento != null && pElemento != null)
        return (aElemento.Equals(pElemento) || aSubLista.ExisteElemento(pElemento));
    else
        return false;
}

//Retorna la posicion del nodo en la lista
public int PosicionElemento(CVertice pElemento)
{
    if (aElemento != null || ExisteElemento(pElemento))
    {
        if (aElemento.Equals(pElemento))
            return 1;
        else
            return 1 + aSubLista.PosicionElemento(pElemento);
    }
    else
        return 0;
}





    }
}
