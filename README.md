## Implementación del Algoritmo de Dijkstra en C# (Windows Forms)

Este proyecto incluye la funcionalidad de búsqueda de la ruta más corta entre dos vértices en un grafo dirigido y ponderado, utilizando el algoritmo de Dijkstra. La solución fue integrada como un evento en una aplicación de escritorio con interfaz gráfica (Windows Forms).

### Cambios realizados
- Se implementó el evento btnRutaCorta_Click, que permite al usuario calcular y visualizar la ruta más corta entre dos vértices seleccionados.

- El algoritmo considera los pesos de los arcos, eligiendo siempre el camino de menor costo total, no necesariamente el más directo.

- Se colorea el recorrido de la ruta en el grafo, mejorando la visualización de los resultados.

### ¿Cómo funciona el algoritmo de Dijkstra?
Dijkstra es un algoritmo de búsqueda que permite encontrar la ruta más corta desde un nodo origen hacia todos los demás nodos en un grafo con pesos no negativos.

### Pasos principales del algoritmo:
Inicializar distancias:

- Se establece la distancia del nodo origen como 0.

- Todos los demás nodos inician con distancia ∞.

Visitar nodos:

- Se elige el nodo con la menor distancia conocida.

- Se actualizan las distancias de sus vecinos si se encuentra un camino más corto.

- Repetir hasta haber visitado todos los nodos o llegar al destino.

- Reconstruir la ruta más corta usando los nodos previos guardados durante el recorrido.

### Ejemplo práctico:
Si existen dos caminos hacia un nodo:

- Camino A → B → C con peso total 2

- Camino A → C directo con peso 3

El algoritmo prefiere A → B → C porque el peso total es menor, incluso si implica más pasos.
