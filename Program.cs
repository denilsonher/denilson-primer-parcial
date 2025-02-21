using System;

// Clase principal
class juegO
{
    static void Main(string[] args)
    {
        string[] palabrasFaciles = { "gato", "sol", "luz", "pan", "mar" };

        Random random = new Random();
        string palabra = palabrasFaciles[random.Next(palabrasFaciles.Length)];

     
        AhorcadoFacil juego = new AhorcadoFacil(palabra, 8);

        Console.WriteLine("¡Bienvenido al juego del ahorcado (modo fácil)!");
        juego.MostrarMensajeFacil();

        while (juego.Intentos > 0 && !juego.HaGanado())
        {
            juego.MostrarEstado();

            Console.Write("Adivina una letra: ");
            char letra = Console.ReadLine().ToLower()[0];

            juego.AdivinarLetra(letra);
        }


        if (juego.HaGanado())
        {
            Console.WriteLine("\n¡Felicidades! Adivinaste la palabra: " + juego.Palabra);
        }
        else
        {
            Console.WriteLine("\n¡Oh no! Te quedaste sin intentos. La palabra era: " + juego.Palabra);
        }
    }
}