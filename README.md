# Interfaces Inteligentes
## Práctica 4
### Diego Herrera Mendoza
Introducción a C#

En esta práctica se ha pedido realizar varios ejercicios de scripting en Unity con C#. Cada ejercicio será escrito con su mostrado con su enunciado y un gif de su correcto funcionamiento.

1. A partir de la escena que has estado utilizando en las últimas prácticas, crea la siguiente mecánica. Cuando el cubo colisiona con el cilindro, las esferas de tipo 1 cambian su color y las esferas de tipo 2 se desplazan hacia el cilindro.

![Ejercicio1](gifs/Ejercicio1.gif)

Script Listener: [Exercise1Listener.cs](scripts/Exercise1Listener.cs)
Script Sender: [Exercise1Sender.cs](scripts/Exercise1Sender.cs)

---

2. Cuando el cubo colisiona con cualquier objeto que no sean esferas del grupo 1, las esferas en el grupo 1 se acercan al cilindro. Cuando el cubo toca cualquier esfera del grupo 1, las esferas del grupo 2 aumentan de tamaño.

![Ejercicio2](images/Ejercicio2.gif)

Script Listener: [Exercise2Listener.cs](scripts/Exercise2Listener.cs)
Script Sender: [Exercise2Sender.cs](scripts/Exercise2Sender.cs)

---

3. Cuando el cubo se aproxima al cilindro, las esferas del grupo 1 cambian su color y saltan y las esferas del grupo 2 se orientan hacia un objeto ubicado en la escena con ese propósito. 

![Ejercicio3](gifs/Ejercicio3.gif)

Script Listener: [Exercise3Listener.cs](scripts/Exercise3Listener.cs)
Script Sender: [Exercise3Sender.cs](scripts/Exercise3Sender.cs)

---

4. Implementar la mecánica de recoger esferas en la escena que actualicen la puntuación del jugador. Las esferas de tipo 1 suman 5 puntos y las esferas de tipo 2 suman 10. Mostrar la puntuación en la consola.

![Ejercicio4](gifs/Ejercicio4.gif)

Script Listener: [Exercise4Listener.cs](scripts/Exercise4Listener.cs)
Script Sender: [Exercise4Sender.cs](scripts/Exercise4Sender.cs)

---

5. Partiendo del script anterior crea una interfaz que muestre la puntuación que va obteniendo el cubo. 

![Ejercicio5](gifs/Ejercicio5.gif)

Script Listener: [Exercise5Listener.cs](scripts/Exercise5Listener.cs)
Script Sender: [Exercise5Sender.cs](scripts/Exercise5Sender.cs)

---

6. Genera una escena que incluya elementos que se ajusten a la escena del prototipo y alguna de las mecánicas anteriores.


---
