class Producto
{
    public string Codigo { get; private set; }
    public string Nombre { get; private set; }
    public int CantidadStock { get; private set; }
    public decimal Precio { get; private set; }
    public Producto(string codigo, string nombre, int cantidadStock, decimal precio)
    {
        Codigo = codigo;
        Nombre = nombre;
        CantidadStock = cantidadStock;
        Precio = precio;
    }
    public void ActualizarStock(int cantidad)
    {
        if (cantidad<=CantidadStock)
        {
            CantidadStock += cantidad;
        }
        else
        {
            Console.WriteLine("No se puede");
        }
    }
}
class OrdenCompra
{
    private List<Producto> _productos;
    public OrdenCompra()
    {
        _productos = new List<Producto>();
    }
    public void AgregarProducto(Producto producto)
    {
        _productos.Add(producto);
    }
    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var producto in _productos)
        {
            total += producto.Precio;
        }
        return total;
    }
    public void MostrarDetalleOrden()
    {
        Console.WriteLine("Detalle de la orden de compra: ");
        Console.WriteLine($"Total de la orden: {CalcularTotal():C}");
        foreach(var producto in _productos)
        {
            Console.WriteLine($"Producto: {producto.Nombre}, Precio: {producto.Precio}");
        }

    }
}