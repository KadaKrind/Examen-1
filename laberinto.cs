using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ejercicio_8_Examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] laberinto = {
             {'S', '#', '.', '#', '#'},
             {'.', '.', '.', '.', '#'},
             {'#', '#', '#', '.', '#'},
             {'#', '.', '.', '.', '.'},
             {'#', '#', '#', '#', 'E'}};
            if (EncontrarCamino(laberinto, 0, 0))
            {
                Console.WriteLine("Estructura del laberinto ↓\n");
                Console.WriteLine("{'S', '#', '.', '#','#'}\n{ '.', '.', '.', '.', '#'}\n{ '#', '#', '#', '.', '#'}\n{'#', '.', '.','.', '.'}\n{ '#', '#', '#', '#', 'E'}\n\n" + "La letra S es de donde va a comenzar y laletra E es la salida del laberinto\n" + "la letra X es por donde se realizo el camino");
                Console.WriteLine("El camino ha sido encontrado:\n");
                ImprimirLaberinto(laberinto);
            }
            else
            {
                Console.WriteLine("No se encontró un camino.");
            }
            Console.ReadKey();
        }
        static bool EncontrarCamino(char[,] laberinto, int x, int y)
        {
            int filas = laberinto.GetLength(0);
            int columnas = laberinto.GetLength(1);
            if (x < 0 || x >= filas || y < 0 || y >= columnas)
                return false;
            if (laberinto[x, y] == 'E')
                return true;
            if (laberinto[x, y] == '#' || laberinto[x, y] == 'X')
                return false;
            laberinto[x, y] = 'X'; 

if (EncontrarCamino(laberinto, x + 1, y) ||
EncontrarCamino(laberinto, x - 1, y) || EncontrarCamino(laberinto, x, y + 1)
|| EncontrarCamino(laberinto, x, y - 1))
                return true;
            laberinto[x, y] = '.'; 
return false;
        }
        static void ImprimirLaberinto(char[,] laberinto)
        {
            int filas = laberinto.GetLength(0);
            int columnas = laberinto.GetLength(1);
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(laberinto[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}



