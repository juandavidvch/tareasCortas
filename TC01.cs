/*
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.\\
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
*/

/*
	Tarea Corta 1
	Estudiante: [JUAN DAVID VILLALOBOS CHACON]
	
	Enunciado:
	Escriba una funcion que retorne el elemento mas grande de una lista no ordenada	
*/

//Your code starts here

//se quiso usar este metodo asi no es limitado a una solucion o uos solos numeros, 
//decidi aplicar un metodo random que llene la lista y luego que solo lea los elementos de la lista aleatoria (no ordenada) y devuelva el mas alto

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0; //controla la cantidad de elementos a ingresar
            int max = 0; //controla el numero maximo a utilizarse fde manera random (funciona como limite)
            Console.Write("Cuantos numeros va a incluir en la lista?: ");
            num = Convert.ToInt16(Console.ReadLine());
            Console.Write("Rango maximo de numeros? Hasta (0-999999): ");
            max = Convert.ToInt16(Console.ReadLine());

            Program calc = new Program();

            System.Console.Write("Numero mayor: {0}", calc.returnHigher(num,max)); //llama metodo que llena lista y analiza numero mayor, 
            //hace envio de la cant de elementos y el numero maximo hasta que podria llegar (no significa que ese sea el maximo)
            Console.ReadKey();
        }

        public int returnHigher(int variable, int maximum)
        {
            List<int> list = new List<int>();
            Random rdm = new Random();          //metodo random que sirve para generar numeros aleatorios
            int i = 0;                          //controla el ciclo de llenado de la lista
            int high = 0;                       //almacena el elemento mas grande de la lista
            do
            {
                list.Add(rdm.Next(maximum));    //carga la lista con numeros aleatorios HASTA el que se pidio como tope
                i++;                            //contador del ciclo
            } while (i != variable);            //HASTA que sean iguales la cant de elementos a incluir y el contador, el ciclo termina

            foreach (int element in list)       //recorre la lista
            {
                if (element > high)             //evalua el elemento actual contra el "mayor"
                    high = element;             //si es mayor, este pasa a ser el "mayor"
            }
            return high;                        //devuelve el mayor
        }
    }
}

