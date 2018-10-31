# InterfacesInteligentes4
* Para esta práctica se nos ha pedido que probasemos a añadir dos objetos tipo Canvas con el fin de aportar un poco de interacción con el usuario durante el juego. 
Para ello lo que hemos hecho es partiendo de la escena que teniamos, crear dos objetos Canvas, un slider y un botón (cada uno con una función diferente). 
1. El slider se encarga de cambiar la iluminación de la fuente de luz. 
2. El botón al ser pulsado cambia el tamaño de un objeto tipo A, representados por esferas. 

## Adición del Canvas. 
Con la interfaz de Unity es muy sencillo añadir interacción con el usuario. Lo primero que hemos hecho ha sido añadir los GameObject buscandolos en la lista de UI dentro de la pestaña GameObject. Una vez los hemos insertado los pasos han sido los siguientes: 
### Para el slider. 
Para este objeto ha sido todo muy intuitivo, lo primero que hemos hecho es añadir la fuente de luz que es el objeto al cual se le aplicará el evento del EventSystem que controla los objetos Canvas. Una vez lo teniamos vinculado, simplemente hemos añadido la función Light.Intensity y en la parte superior colocarle un valor máximo como recorrido del slider, para nosotros ese valor máximo ha sido 10. 
* Finalmente este ha sido el resultado: 
![](practica4.gif)

### Para el botón.
Para el botón lo que hemos cambiado ha sido la función OnClick que nos proporciona unity como Component de este mismo. El esquema es basicamente el mismo al del slider. 
* Hacemos referencia al objeto al cual se le aplicará el evento y luego elegimos la función que queremos que se ejecute del mismo al botón sel pulsado. En este caso la funció se encontraba en el script de dicho objeto y era cambiarTam(), la cual cambiaba el tamaño del objeto. 
* Este ha sido el resultado. 
![](practica4-2.gif)
