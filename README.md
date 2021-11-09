# Practica_06_ChristianTorresGonzalez

Para la realización de esta sexta práctica, desarrollaré un nuevo escenario,  donde trabajaré con herramientas 2D para el desarrollo de juegos de este tipo. Dentro de esta practica, se desarrollarán diversos puntos a cumplir:
1.  Obtener assets que incorpores a tu proyecto: Sprites individuales y Atlas de  [Sprites.](https://campusdoctoradoyposgrado2122.ull.es/mod/resource/view.php?id=21711 "Sprites.")
2.  Incorporar los recursos del punto 1 en el proyecto y generar al menos 2 animaciones para uno de los personajes.
3.  Busca en el inspector de objetos la propiedad Flip y comprueba qué pasa al activarla desactivarla en alguno de los ejes.
4.  Mover uno de los personajes con el eje horizontal virtual que definen las teclas de flechas.
5.  Hacer saltar el personaje y cambiar de dirección cuando se pulsa la barra espaciadora.  
    
6.  Crear una animación para otro personaje, que se active cuando el jugador pulse la tecla x.
7.  Agregar un objeto que al estar el personaje a una distancia menor que un umbral se active una animación, por ejemplo explosión o cualquier otra que venga en el atlas de  [sprites.](https://campusdoctoradoyposgrado2122.ull.es/mod/resource/view.php?id=21711 "Sprites.")   

## Obtener e incorporar assets
Dado que la primera tarea es seleccionar el asset a utilizar, incluiré el segundo punto dentro de la explicación ya que es completar el primero añadiendo el sprite seleccionado a la escena. Para ello lo unico que he hecho ha sido buscar por internet sprite que me hayan gustado y un fondo para darle forma a la escena:

 ![Alt text](/img/sprite.png)
 
 ![Alt text](/img/fondo.png)

## Generar animaciones para personaje
Para esta segunda tarea lo que he hecho ha sido es seleccionar alguno de las imágenes contenidas en el sprite, y juntarlas para que el personaje tenga una animación que realizar:
 
 ![Alt text](/img/animaciones.png)
 
- **Animación caminar**
 ![Alt text](/img/caminar.gif)
 
 - **Animación disparar**
 ![Alt text](/img/disparar.gif)
 
 - **Animación morir**
 ![Alt text](/img/morir.gif)


## Opción Flip en inspector
Al seleccionar la opción Flip en el inspector sobre nuestro personaje, lo que ocurrirá es que se aplica una transformación horizontal, es decir, pasa a mirar al lado contrario

![Alt text](/img/flip.gif)

## Controlar jugador
Para este punto se pide que mediante las teclas "WASD" podamos mover un objeto dentro de la escena. Para ello lo que he hecho ha sido desarrollar un script con el cual mediante las teclas "a" y "d" se podrá mover el jugador por la escena.

![Alt text](/img/movimiento.png)

![Alt text](/img/movimiento.gif)

## Salto del jugador
Para este punto se pide que mediante la tecla "Espacio" podamos saltar con nuestro personaje en la escena. Para ello lo que he hecho ha sido desarrollar un script con el cual mediante la tecla espacio, se aplicara una fuerza vertical al rigidbody de nuestro personaje.

![Alt text](/img/salto.png)

![Alt text](/img/salto.gif)

## Animacion otro personaje
Para este punto se pide que mediante la tecla "x", cuando esta es pulsada, otro personaje de nuestra escena, realice una animación. Para ello lo que he hecho ha sido crear una variable bool en nuestro "Animator", que funcionara como condición para saber que se ha pulsado la tecla y que se tiene que realizar la animación.

![Alt text](/img/animacion.png)

![Alt text](/img/animacion.gif)

## Proximidad a objeto
Para este punto se pide que cuando nuestro jugador se aproxime a un objeto situado en la escena, este realice una animación diferente. Para realizarlo, de la misma manera que el punto anterior, lo que hago es crear una variable bool en el animador, que se va a encargar de determinar cuando se debe realizar la animación o no, en caso de que la distancia entre el jugador y el objeto sea menor a un umbral, se activara dicha variable y se realizará la animación.

![Alt text](/img/proximidad.png)

![Alt text](/img/proximidad.gif)
