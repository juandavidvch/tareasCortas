/*
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
*/

/*
	Tarea Corta 2
	Estudiante: [Your Name]
	
	Enunciado:
	Escriba una funcion que le de vuelta a una lista, debe imprimir primero la lista original, y luego imprimir la lista invertida.
	Preferiblemente, darle vuelta a la lista sin crear una lista nueva.
*/

//Your code starts here

//se decidio esta solucion con metodo para no alterar la lista original que se precargo.
//se usa propiedad REVERSE para invertir los elementos (ENTEROS) de la lista, tambien se puede usar string
//SI es que se cambia el tipo de lista. solo que en este caso, lo quise llenar con elementos RANDOM

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasModule
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;                        //controla la cantidad de elementos a ingresar
            int max = 0;                        //controla el numero maximo a utilizarse fde manera random (funciona como limite)
            Console.Write("Cuantos numeros va a incluir en la lista?: ");
            num = Convert.ToInt16(Console.ReadLine());
            Console.Write("Rango maximo de numeros? Hasta (0-999999): ");
            max = Convert.ToInt16(Console.ReadLine());
            List<int> list = new List<int>();
            Random rdm = new Random();          //metodo random que sirve para generar numeros aleatorios
            int i = 0;                          //controla el ciclo de llenado de la lista
            do
            {
                list.Add(rdm.Next(max));        //carga la lista con numeros aleatorios HASTA el que se pidio como tope
                i++;                            //contador del ciclo
            } while (i != num);                 //HASTA que sean iguales la cant de elementos a incluir y el contador, el ciclo termina
            Program calc = new Program();
            calc.reverseList(list);             //llama metodo para dar vuelta a la lista, envia la lista precargada
            Console.ReadKey();
        }

        public void reverseList(List<int> list)
        {
            Console.WriteLine("Lista actual:");         
            foreach (int a in list)
                Console.WriteLine("{0}", a);            //imprime la lista actual tal como se recibio
            
            list.Reverse();                             //propiedad que permite invertir la lista, si era A-Z, ahora es Z-A
            
            Console.WriteLine("\nLista invertida:");
            foreach (int a in list)
                Console.WriteLine("{0}", a);            //imprime la lista invertida de la anterior
        }
    }
}
