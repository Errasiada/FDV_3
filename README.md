# FDV_3
### :new_moon: Practice 3

Este repositorio recoge los ejercicios realizados para la tercera práctica de FDV (apartados 1,2 y 8)

Primero crearemos un objeto en la escena, en este caso, una esfera. Una vez creada la esfera haremos un script que mueva el objeto hacia un punto fijo marcado como **objetivo**. Éste debe ser una variable de tipo _public_ para manipular los valores en el inspector.

-  1. Configuramos la coordenada Y del **objetivo** 0. Colocamos al objetivo en una coordenada Y distinta a 0

![1agif](https://user-images.githubusercontent.com/114673717/197336338-32ac9dce-5c86-482d-b83d-764bdc24bc8f.gif)

-  Luego modificamos el script para que el objeto despegue del suelo.

![1gif](https://user-images.githubusercontent.com/114673717/197336484-0d847abf-9355-422f-bf48-5f4682d98a2f.gif)

-  2. Utilizaremos un vector normalizado para ajustar la velocidad de nuestra esfera, y probaremos a multiplicar un valor de velocidad para ver cómo de rápido se desplaza. Como la velocidad dependerá del _Update_ debemos multiplicarlo por Time.deltaTime para suavizar el movimiento desde el último frame.

![2gif](https://user-images.githubusercontent.com/114673717/197336697-2fe6eb62-3c2b-4645-b12d-da899bbed768.gif)

-  3. Ahora en lugar de usar una dirección como objetivo, nos movemos hacia una posición objetivo determinando la diferencia entre la posición del objetivo y la posición del objeto inicial.


![3gif](https://user-images.githubusercontent.com/114673717/197337167-5c19d1dd-fe45-479d-a8f1-4fc525e61519.gif)

-  4. En este caso al ejecutar el script la esfera calcula la dirección hacia el objetivo y se mueve hacia él sin poder dejar de moverse creando un _jittering_. Utilizando una variable pública de accuracy el personaje oscilará en torno a esa posición.


![4gif](https://user-images.githubusercontent.com/114673717/197337560-26d8e2fc-d118-466c-9e9d-80f4a9ed6585.gif)


-  5. Ahora usaremos el método _LookAt_ para que nuestra esfera realice una rotación y posteriormente avance hacia el objetivo.

![5gif](https://user-images.githubusercontent.com/114673717/197338019-902cd556-e411-453a-aafd-dd85a4fecc3b.gif)

- 6. Añadiremos una depuración para comprobar que la dirección se ha calculado bien.

![6gif](https://user-images.githubusercontent.com/114673717/197338326-545ffcba-935c-4df2-a2c7-2f60b0f56f82.gif)

- 7. (PENDIENTE)
- 8. En este caso crearemos una escena con tres objetos: dos esferas y un cubo. Primero ningún objeto tendrá físicas, luego sólo las esferas tendran fisicas y el cubo no. Finalmente todos los elementos tienen físicas, el cubo comienza por encima de las esferas y observamos esto si le damos al play.

![8cgif](https://user-images.githubusercontent.com/114673717/197338608-4f89ac88-c585-478f-9005-da627b700912.gif)

Esto es lo que ocurre si la esfera tiene 10 veces más masa que el cubo

![8dgif](https://user-images.githubusercontent.com/114673717/197338634-5a6b03ac-1125-4795-a70c-ab0127ea8620.gif)

Si el cubo es tipo IsTrigger estático.

![8egif](https://user-images.githubusercontent.com/114673717/197338739-4221350c-db38-484e-b056-5b1ee4e87f2e.gif)


Si el cubo es IsTrigger cinemático.

![8fgif](https://user-images.githubusercontent.com/114673717/197338668-0443a00a-bf09-4c45-9e76-5e2a8e895a8d.gif)

Si el cubo es IsTrigger mecánico.


![8ggif](https://user-images.githubusercontent.com/114673717/197338918-bc0a9eab-425a-496e-9d86-3bc85b952a7b.gif)

- 9. Ahora convertiremos al cubo en un personaje que moveremos con un script de CharacterController. Cuando el jugador pulse wasd se moverá en la dirección indicada.

Crearemos el script sin aplicar físicas.

![9agif](https://user-images.githubusercontent.com/114673717/197339017-ebe8afdc-cefa-4026-8709-b5aba6c3ab20.gif)

Le daremos una velocidad graduable desde el inspector de objetos creando una variable de speed tipo _public_

![9bgif](https://user-images.githubusercontent.com/114673717/197339032-53aeb89d-539b-4398-a634-756be8275f77.gif)

Si pulsamos la tecla espacio, se incrementará gradualmente la velocidad del objeto.

![9cgif](https://user-images.githubusercontent.com/114673717/197339091-750ab310-43ff-4006-973d-751463eb6c25.gif)

-  10. (PENDIENTE)








