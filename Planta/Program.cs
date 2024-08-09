class Planta
{
    public string Nombre { get; set; }
    public Planta(string nombre)
    {
        Nombre = nombre;
    }
    public virtual void Florecer()
    {
        Console.WriteLine($"Verano: {Nombre} desconocido\nOtoño: {Nombre} desconocido\nInvierno: {Nombre} desconocido\nPrimavera: {Nombre} desconocido\n");
    }
}
class Flor : Planta
{
    public Flor(string nombre) : base(nombre) { }
    public override void Florecer()
    {
        Console.WriteLine($"Verano: {Nombre} florece\nOtoño: {Nombre} no florece\nInvierno: {Nombre} no florece\nPrimavera: {Nombre} florece\n");
    }
}
class Arbol : Planta
{
    public Arbol(string nombre) : base(nombre) { }
    public override void Florecer()
    {
        Console.WriteLine($"Verano: {Nombre} no florece\nOtoño: {Nombre} florece\nInvierno: {Nombre} florece\nPrimavera: {Nombre} no florece\n");
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Ingrese nombre de la planta: ");
        Planta plantita = new Planta(Console.ReadLine() ?? "");
        plantita.Florecer();

        Console.Write("Ingrese nombre de la flor: ");
        Planta florcita = new Flor(Console.ReadLine() ?? "");
        florcita.Florecer();

        Console.Write("Ingrese nombre del arbol: ");
        Planta arbolito = new Arbol(Console.ReadLine() ?? "");
        plantita.Florecer();
    }
}