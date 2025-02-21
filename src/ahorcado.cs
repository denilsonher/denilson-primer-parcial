class JuegoAhorcado
{
    public string Palabra { get; set; }
    public int Intentos { get; set; }
    public List<char> LetrasAdivinadas { get; set; }

    public JuegoAhorcado(string palabra, int intentos)
    {
        Palabra = palabra;
        Intentos = intentos;
        LetrasAdivinadas = new List<char>();
    }

    public void MostrarEstado()
    {
        Console.WriteLine("\nPalabra: " + ObtenerPalabraOculta());
        Console.WriteLine("Intentos restantes: " + Intentos);
        Console.WriteLine("Letras adivinadas: " + string.Join(", ", LetrasAdivinadas));
    }

    public string ObtenerPalabraOculta()
    {
        string resultado = "";
        foreach (char letra in Palabra)
        {
            resultado += LetrasAdivinadas.Contains(letra) ? letra + " " : "_ ";
        }
        return resultado;
    }

    public bool AdivinarLetra(char letra)
    {
        if (LetrasAdivinadas.Contains(letra))
        {
            Console.WriteLine("Ya adivinaste esa letra. Intenta con otra.");
            return false;
        }

        LetrasAdivinadas.Add(letra);

        if (Palabra.Contains(letra))
        {
            Console.WriteLine("¡Correcto! La letra está en la palabra.");
            return true;
        }
        else
        {
            Console.WriteLine("Incorrecto. La letra no está en la palabra.");
            Intentos--;
            return false;
        }
    }

    public bool HaGanado()
    {
        return !ObtenerPalabraOculta().Contains('_');
    }
}