using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
//4. Crear una variable para guardar los nombres de elementos para una “lista de
//supermercado”. Solicitar al usuario que ingrese el nombre de un elemento
//que va a comprar en el super y verificar que el elemento esté en la lista. Si no
//está, agregarlo e indicar que no estaba. Si está, quitarlo de la lista, y avisar
//que sí estaba. Al finalizar mostrar por pantalla los elementos que no compró y
//los que compró, pero no estaban en la lista. Si se quiere, mostrar también
//todos los elementos que el usuario compró. Para salir el usuario debe ingresar “fin”.
namespace Guia3.Ejercicio4
{
    internal class Producto
    {
        public string nombre;

        public Producto() { }

        public List<string> listaDeProductos()
        {
            List<string> listaDeProductos = new List<string>();

            listaDeProductos.Add("pan");
            listaDeProductos.Add("leche");
            listaDeProductos.Add("queso");
            listaDeProductos.Add("jamon");
            listaDeProductos.Add("tomate");
            listaDeProductos.Add("huevo");
            listaDeProductos.Add("aceite");

            return listaDeProductos;
        }

        public string[][] comprar(List<string> listaDeProductos)
        {
            List<string> productosComprados = new List<string>();
            List<string> productosAgregados = new List<string>();
            string[][] listas = new string[2][];
            string[] listProducts, addedProducts, buyProducts;
            string prodElegir = "", res = "", cont = "";

            Console.WriteLine("¿Realizar compra? s/n");
            res = Console.ReadLine().ToLower();

            if (res == "s")
            {
                do
                {
                    Console.WriteLine("Escriba producto para comprar");
                    prodElegir = Console.ReadLine().ToLower();

                    if (listaDeProductos.Contains(prodElegir))
                    {
                        listaDeProductos.Remove(prodElegir);
                        productosComprados.Add(prodElegir);
                        Console.WriteLine("El producto si está en la lista.");
                    }
                    else
                    {
                        productosComprados.Add(prodElegir);
                        listaDeProductos.Add(prodElegir);
                        Console.WriteLine("El producto no se encontraba a la lista de disponibles, pero fue agregado.");
                    }

                    do
                    {
                        Console.WriteLine("¡Continuar comprando? s/n");
                        cont= Console.ReadLine().ToLower();

                    } while (cont != "s" && cont != "n");

                } while (cont == "s");

                listProducts = new string[listaDeProductos.Count];
                buyProducts = new string[productosComprados.Count];

                for (int i = 0; i <= listProducts.Length - 1; i++)
                {
                    listProducts[i] = listaDeProductos[i];
                }

                for (int i = 0; i <= buyProducts.Length - 1; i++)
                {
                    buyProducts[i] = productosComprados[i];
                }

                listas[0] = new string[listaDeProductos.Count];
                listas[1] = new string[productosComprados.Count];

                listas[0] = listProducts;
                listas[1] = buyProducts;

                return listas;
            }
            else
            {
                Console.WriteLine("Programa finalizado");
            }


            return listas;
        }
    }
}
