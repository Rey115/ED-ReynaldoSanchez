EJERCICIO 2 (35 puntos): RED DE COMPUTADORAS

Una oficina tiene la siguiente red:

- El Router principal conecta con: Servidor, Switch1, Switch2
- Switch1 conecta con: PC1, PC2, Impresora1
- Switch2 conecta con: PC3, PC4, Impresora2
- El Servidor conecta con: Router (ya mencionado)

Responde:
a) Dibuja el grafo de la red

b) ¿Cuántos vértices y aristas tiene?
Contiene 10 vértices y 9 aristas

c) ¿Es conexo? ¿Qué significa esto para la red?
Si es conexo porque hay un camino de cualquier vértice a otro. Significa que se pueden comunicar todos los dispositivos entre sí.

d) ¿Es un árbol? Justifica
Sí porque cumple la regla de:
Un árbol con n vértices siempre tiene n-1 aristas
En este caso tiene 10 vértices y 9 aristas

e) Si se desconecta el Router, ¿cuántas componentes conexas quedan?
Quedan 3

El primer componente sería el Servidor que queda solo y se hace conexo.

El segundo sería Switch1 + PC1 + PC2 + Impresora1

El tercero Switch2 + PC3 + PC4 + Impresora2


f) ¿Cuál es el dispositivo más crítico de la red? (si falla, más dispositivos quedan aislados)
El router porque conecta a 3 diferentes componentes que si falla pierden comunicación los 2 switches con el servidor. 


