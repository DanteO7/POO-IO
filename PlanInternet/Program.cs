class PlanInternet
{
    private string _nombrePlan = null!;
    private int _velocidad;
    private decimal _precioMensual;
    public PlanInternet(string nombrePlan, int velocidad, decimal precioMensual)
    {
        NombrePlan = nombrePlan;
        Velocidad = velocidad;
        PrecioMensual = precioMensual;
    }
    public string NombrePlan
    {
        get { return _nombrePlan; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _nombrePlan = value;
            }
            else
            {
                Console.WriteLine("El nombre del plan no puede ser nulo");
            }
        }
    }
    public int Velocidad
    {
        get { return _velocidad; }
        set
        {
            if(value > 0)
            {
                _velocidad = value;
            }
            else
            {
                Console.WriteLine("La velocidad de internet no puede ser menor o igual a 0 (cero)");
            }
        }
    }
    public decimal PrecioMensual
    {
        get { return _precioMensual; }
        set
        {
            if(value > 0)
            {
                _precioMensual = value;
            }
            else
            {
                Console.WriteLine("El precio mensual no puede ser menor o igual a 0 (cero)");
            }
        }
    }
    protected void DetallesRepetidos()
    {
        Console.WriteLine($"Nombre del plan: {NombrePlan}\nVelocidad de internet (Mbps): {Velocidad}\nPrecio mensual: {PrecioMensual}");
    }
    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"\nPlan Internet");
        DetallesRepetidos();
    }
}
class PlanResidencial : PlanInternet
{
    public PlanResidencial(string nombrePlan, int velocidad, decimal precioMensual) : base(nombrePlan, velocidad, precioMensual) { }
    public override void MostrarDetalles()
    {
        Console.WriteLine("\nPlan Residencial");
        DetallesRepetidos();
    }
}
class PlanEmpresarial : PlanInternet
{
    public PlanEmpresarial(string nombrePlan, int velocidad, decimal precioMensual) : base(nombrePlan, velocidad, precioMensual) { }
    public override void MostrarDetalles()
    {
        Console.WriteLine("\nPlan Empresarial");
        DetallesRepetidos();
    }
}
class PlanMovil : PlanInternet
{
    public PlanMovil(string nombrePlan, int velocidad, decimal precioMensual) : base(nombrePlan, velocidad, precioMensual) { }
    public override void MostrarDetalles()
    {
        Console.WriteLine("Plan Movil");
        DetallesRepetidos();
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione el plan que desea obtener:");
        Console.WriteLine("1 - Plan Residencial");
        Console.WriteLine("2 - Plan Empresarial");
        Console.WriteLine("3 - Plan Móvil");
        int plan;
        int.TryParse(Console.ReadLine(), out plan);
        bool bandera = true;

        while (bandera)
        {
            switch (plan)
            {
                case 1:
                    Console.Write("Ingrese nombre del plan: ");
                    string nombrePlan = Console.ReadLine() ?? "";
                    Console.Write("Ingrese velocidad (Mbps) del plan: ");
                    int velocidadPlan;
                    int.TryParse(Console.ReadLine(), out velocidadPlan);
                    Console.Write("Ingrese precio mensual del plan: ");
                    decimal precioMensual;
                    decimal.TryParse(Console.ReadLine(), out precioMensual);
                    PlanInternet miPlan = new PlanResidencial(nombrePlan, velocidadPlan, precioMensual);
                    if (!string.IsNullOrEmpty(nombrePlan) && velocidadPlan>0 && precioMensual>0)
                    {
                        miPlan.MostrarDetalles();
                    }
                    bandera = false;
                    break;
                case 2:
                    Console.Write("Ingrese nombre del plan: ");
                    nombrePlan = Console.ReadLine() ?? "";
                    Console.Write("Ingrese velocidad (Mbps) del plan: ");
                    int.TryParse(Console.ReadLine(), out velocidadPlan);
                    Console.Write("Ingrese precio mensual del plan: ");
                    decimal.TryParse(Console.ReadLine(), out precioMensual);
                    miPlan = new PlanEmpresarial(nombrePlan, velocidadPlan, precioMensual);
                    if (!string.IsNullOrEmpty(nombrePlan) && velocidadPlan > 0 && precioMensual > 0)
                    {
                        miPlan.MostrarDetalles();
                    }
                    bandera = false;
                    break;
                case 3:
                    Console.Write("Ingrese nombre del plan: ");
                    nombrePlan = Console.ReadLine() ?? "";
                    Console.Write("Ingrese velocidad (Mbps) del plan: ");
                    int.TryParse(Console.ReadLine(), out velocidadPlan);
                    Console.Write("Ingrese precio mensual del plan: ");
                    decimal.TryParse(Console.ReadLine(), out precioMensual);
                    miPlan = new PlanMovil(nombrePlan, velocidadPlan, precioMensual);
                    if (!string.IsNullOrEmpty(nombrePlan) && velocidadPlan > 0 && precioMensual > 0)
                    {
                        miPlan.MostrarDetalles();
                    }
                    bandera = false;
                    break;
                default:
                    Console.WriteLine("Ingrese un numero válido\n");
                    Console.WriteLine("Seleccione el plan que desea obtener:");
                    Console.WriteLine("1 - Plan Residencial");
                    Console.WriteLine("2 - Plan Empresarial");
                    Console.WriteLine("3 - Plan Móvil");
                    int.TryParse(Console.ReadLine(), out plan);
                    break;
            }
        }
    }
}
