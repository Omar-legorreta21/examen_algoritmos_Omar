using System;
using System.Runtime.Intrinsics.X86;
using System.Text.Json;
using System.Xml.Linq;
using System.Text.Json.Serialization;
namespace CSharpExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Selecciona el ejercicio que desees ver \r\n 1.- Comparador de calificaciones \r\n 2.- Cantidad de palabras ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num==1)
            {
                primerejersicio();
            }
            else if(num==2)
            {
                sundoejersicio();
            }
            else
            {
                Console.Write("Valor no es correcto adios");

            }
        }
        public static void primerejersicio()
        {
            string[] categorias = { "claridad del problema", "originalidad", "dificultad" };
            int[] a = { 10, 3, 5 };
            int[] b = { 1, 30, 5 };
            int bob = 0;
            int alice = 0;
            for (int j = 0; j < categorias.Length; j++)
            {
                Console.Write("Ingresa la calificación de Alice en la categoria " + categorias[j]);
                int num = Convert.ToInt32(Console.ReadLine());
                if (num >= 1 && num <= 100)
                {
                    a[j] = num;
                }
                else
                {
                    Console.Write("Valor ingresado en la categoria " + categorias[j] + " no es valido");
                    j = j - 1;
                }
            }
            for (int j = 0; j < categorias.Length; j++)
            {
                Console.Write("Ingresa la calificación de Bob en la categoria " + categorias[j]);
                int num = Convert.ToInt32(Console.ReadLine());
                if (num >= 1 && num <= 100)
                {
                    b[j] = num;
                }
                else
                {
                    Console.Write("Valor ingresado en la categoria " + categorias[j] + " no es valido");
                    j = j - 1;
                }
            }



            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] > b[i])
                {
                    bob = bob + 1;

                }
                if (a[i] == b[i])
                {
                }
                if (a[i] < b[i])
                {
                    alice = alice + 1;

                }
            }
            int[] resultado = { alice, bob };
            Console.WriteLine(String.Join("\n", resultado));
        }
        public static void sundoejersicio()
        {
            string texto = "Érase una vez una niñita que lucía una hermosa capa\r\nde color rojo. Como la niña la usaba muy a menudo, todos la\r\nllamaban Caperucita Roja. Un día, la mamá de Caperucita Roja la\r\nllamó y le dijo: —Abuelita no se siente muy bien, he horneado\r\nunas galletitas y quiero que tú se las lleves. —Claro que sí\r\n—respondió Caperucita Roja, poniéndose su capa y llenando su\r\ncanasta de galletas recién horneadas. Antes de salir, su mamá\r\nle dijo: — Escúchame muy bien, quédate en el camino y nunca\r\nhables con extraños. —Yo sé mamá —respondió Caperucita Roja y\r\nsalió inmediatamente hacia la casa de la abuelita.";
            string[] num = texto.Split(' ');
            Console.WriteLine(texto);
            string jsonstr = "{ ";
            for (int i = 0; i < num.Length; i++)
            {
                int cant = 1;
                string cad1 = num[i];
                for(int j=i+1; j < num.Length; j++)
                {
                    if (cad1 == num[j])
                    {
                        num[j] = null;
                        cant = cant + 1;
                    }
                }
                if (num[i] != null) {
                    jsonstr = jsonstr + num[i] +":"+ cant + ",";
                }
            }

            Console.WriteLine(jsonstr);
           
        }
    }
}

