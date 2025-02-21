class AhorcadoFacil : JuegoAhorcado
{
  
    public AhorcadoFacil(string palabra, int intentos) : base(palabra, intentos) { }

    public void MostrarMensajeFacil()
    {
        Console.WriteLine("¡Este es el modo fácil, buena suerte");
    }
}