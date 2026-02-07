**Propósito del proyecto:**

Este proyecto tiene como propósito la utilización de genéricos y delegados, donde se está tratando con tipos de datos númericos diferentes para realizar diferentes tipos de operaciones matemáticas donde si la lista no contiene al menos dos elementos no se puede hacer las operaciones. 

**Descripción general de la aplicación:**

La aplicación permite que el usuario pueda crear y manipular una lista de números de tipo genérico (enteros, flotantes, dobles y decimales) mediante una interfaz de consola, donde el usuario puede ir añadiendo elementos (números de cualquier tipo) y hacer operaciones matemáticas con dichos elementos como (suma, resta, multiplicación y división). 

**Explicación de los métodos utilizados:**

- **Main:** Viene siendo la entrada, allí es donde el usuario solicita el tipo de dato numérico.

- **RunMenu<T>:** Es un método genérico que muestra las opciones del menú. Este permite agregar números y poder ejecutar operaciones matemáticas ya definidas para el tipo de dato numérico seleccionado.

- **Add:** Añadir valor al listado de elementos.

- **Operar:** Se utiliza para aplicar cualquier tipo de operación matemática a los elementos de la lista.

**Instrucciones para ejecutar el programa:**

Se debe de seleccionar añadir un valor por lo menos dos veces hasta que el conteo del elemento sea igual a 2, después seleccionar el tipo de operación matemática que se desea realizar y al finalizar, se puede finalizar la ejecucción. 

**Descripción de las excepciones manejadas:**

- **FormatException:** se utiliza cuando el usuario ingresa o digita un valor no numérico, lo cual manda o arroja un mensaje de error y manda al usuario a ingresar o insertar un nuevo valor.

- **DivideByZeroException:** se utiliza para cuando el usuario intente dividir entre cero, este arroje un mensaje específico que le indica que no se puede dividir entre cero. 

- **InvalidOperationException:** se utiliza cuando el usuario intenta realizar una operación matemática con menos de dos elementos en la lista. El programa arroja que la operación necesita al menos dos elementos en la lista para poder realizar la operación matemática deseada.

**Utilización de genéricos y delegados en el código:**

- **Genéricos: **La clase ListNumGenerico<T> y el método RunMenu<T> utilizan genéricos para poder trabajar con diferentes tipos de datos numéricos sin duplicar el código.

- ** Delegados: **se hace la definición en OperacionMetematica<T> para poder representar los que son las operaciones que necesiten al menos dos valores como lo son: suma, resta, multiplicación y división que están implementadas como lambdas y se pasan al método Operar de la clase ListNumGenerico.

