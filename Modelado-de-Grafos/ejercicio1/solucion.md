EJERCICIO 1 (35 puntos): SISTEMA DE VUELOS

Una aerolínea tiene los siguientes vuelos (solo ida):

| Origen   | Destino  | Precio |
|----------|----------|--------|
| México   | Cancún   | $1500  |
| México   | Monterrey| $1200  |
| Cancún   | Miami    | $3500  |
| Monterrey| Houston  | $2800  |
| Houston  | Miami    | $1800  |
| Miami    | México   | $4000  |

Responde:
a) Dibuja el grafo (con flechas y precios)

b) ¿Está dirigido o no dirigido? ¿Es ponderado?
Si es dirigido porque las aristas tienen una dirección, que en este caso representan de que lugar parte el vuelo y adonde llega.  La flecha apunta hacia el destino. 

Y si es ponderado, porque cada arista tiene un valor, en este caso el precio del boleto.


c) Calcula el grado de entrada y salida de cada ciudad

México: entrada = 1, salida = 2
Cancún: entrada = 1, salida = 1
Monterrey: entrada = 1, salida = 1
Houston: entrada = 1, salida = 1
Miami: entrada = 2, salida = 1

d) ¿Cuál ciudad tiene más vuelos salientes?
México

e) Encuentra la ruta más barata de México a Miami
La ruta mas  barata es
México → Cancún → Miami
El costo es = 1500 + 3500 = 5000

Ya que la otra opción es esta
México → Monterrey → Houston → Miami
El costo de la otra única ruta alternativa es = 1200 + 2800 = 4000; 4000 + 1800 = 5800
Esta ruta termina siendo 800 pesos mas cara


f) ¿Existe algún ciclo? Si sí, descríbelo
Si, existe un ciclo, un camina que empieza termina en el mismo vértice que es el siguiente:
México → Cancún → Miami → México
