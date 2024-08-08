class Libro
{
    public string Titulo {  get; set; }
    public string Autor {  get; set; }
    public string Genero { get; set; }
    public int NumeroDePaginas { get; set; }
    public Libro(string titulo, string autor, string genero, int numeroDePaginas)
    {
        Titulo = titulo;
        Autor = autor;
        Genero = genero;
        NumeroDePaginas = numeroDePaginas;
    }
    public void MostrarInformacionLibro()
    {
        Console.WriteLine($"\nTitulo: {Titulo}\nAutor: {Autor}\nGenero: {Genero}\nNumero de paginas: {NumeroDePaginas}\n ");
    }
}
class Program
{
    static void Main()
    {
        string titulo, autor, genero;
        int numeroDePaginas;

        Console.Write("Ingrese el titulo del libro: ");
        titulo = Console.ReadLine();

        Console.Write("Ingrese el autor del libro: ");
        autor = Console.ReadLine();

        Console.Write("Ingrese el genero del libro: ");
        genero = Console.ReadLine();

        Console.Write("Ingrese el numero de paginas del libro: ");
        int.TryParse(Console.ReadLine(), out numeroDePaginas);

        Libro libro = new Libro(titulo, autor, genero, numeroDePaginas);
        libro.MostrarInformacionLibro();
    }
}