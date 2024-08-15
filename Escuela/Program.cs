class Administrador
{
    private string _nombre = null!;
    private int _experiencia;
    public string Nombre
    {
        get { return _nombre; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _nombre = value;
            }
            else
            {
                throw new ArgumentException("El nombre no debe ser negativo");
            }
        }
    }
    public int Experiencia
    {
        get { return _experiencia; }
        set
        {
            if (value > 0)
            {
                _experiencia = value;
            }
            else
            {
                throw new ArgumentException("La experiencia no debe ser negativa");
            }
        }
    }
    public Administrador(string nombre, int experiencia)
    {
        Nombre = nombre;
        Experiencia = experiencia;
    }
    public void MostrarDetalles()
    {
        Console.WriteLine($"Administrador. Nombre: {Nombre}, Experiencia: {Experiencia} años\n");
    }
}
class Materia
{
    private string _nombre = null!;
    public string Nombre
    {
        get { return _nombre; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _nombre = value;
            }
            else
            {
                throw new ArgumentException("El nombre no debe ser negativo");
            }
        }
    }
    public Materia(string nombre)
    {
        Nombre = nombre;
    }
    public void MostrarDetalles()
    {
        Console.WriteLine($"Materia. Nombre: {Nombre}\n");
    }
}
class Profesor
{
    private string _nombre = null!;
    public string Nombre
    {
        get { return _nombre; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _nombre = value;
            }
            else
            {
                throw new ArgumentException("El nombre no debe ser negativo");
            }
        }
    }
    public Materia Materia { get; set; }
    public Profesor(string nombre, Materia materia)
    {
        Nombre = nombre;
        Materia = materia;
    }
    public void MostrarDetalles()
    {
        Console.WriteLine($"Profesor. Nombre: {Nombre}, Materia: {Materia.Nombre}\n");
    }
}
class Estudiante
{
    private string _nombre = null!;
    private int _edad;
    public string Nombre
    {
        get { return _nombre; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _nombre = value;
            }
            else
            {
                throw new ArgumentException("El nombre no debe ser negativo");
            }
        }
    }
    public int Edad
    {
        get { return _edad; }
        set
        {
            if (value > 0)
            {
                _edad = value;
            }
            else
            {
                throw new ArgumentException("La edad no debe ser negativa");
            }
        }
    }
    public Estudiante(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
    public void MostrarDetalles()
    {
        Console.WriteLine($"Estudiante. Nombre: {Nombre}, Edad: {Edad} años\n");
    }
}
class Aula
{
    private string _nombre = null!;
    public string Nombre
    {
        get { return _nombre; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _nombre = value;
            }
            else
            {
                throw new ArgumentException("El nombre no debe ser negativo");
            }
        }
    }
    public Profesor Profesor { get; set; }
    public List<Estudiante> Estudiantes { get; set; }
    public Aula(string nombre, Profesor profesor, List<Estudiante> estudiantes)
    {
        Nombre = nombre;
        Profesor = profesor;
        Estudiantes = estudiantes;
    }
    public void MostrarDetalles()
    {
        Console.WriteLine($"\nAula. Nombre: {Nombre}, Profesor: {Profesor.Nombre}, Materia: {Profesor.Materia.Nombre}\nAlumnos: ");
        foreach (var estudiante in Estudiantes)
        {
            Console.WriteLine(estudiante.Nombre);
        }
    }
}
class Escuela
{
    private string _nombre = null!;
    public string Nombre
    {
        get { return _nombre; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _nombre = value;
            }
            else
            {
                throw new ArgumentException("El nombre no debe ser negativo");
            }
        }
    }
    public List<Aula> Aulas { get; set; }
    public Administrador Administrador { get; set; }

    public Escuela(string nombre, List<Aula> aulas, Administrador administrador)
    {
        Nombre = nombre;
        Aulas = aulas;
        Administrador = administrador;
    }
    public void MostrarDetalles()
    {
        Console.WriteLine($"\nEscuela. Nombre: {Nombre}, Administrador: {Administrador.Nombre}\nAulas: ");
        foreach (var aula in Aulas)
        {
            aula.MostrarDetalles();
        }
    }
}
class Program
{
    static void Main()
    {
        Administrador administradorcito = new Administrador("Juan Perez", 15);

        Materia materita1 = new Materia("Matematica");
        Materia materita2 = new Materia("Lengua");

        Profesor profesorcito1 = new Profesor("Maria", materita1);
        Profesor profesorcito2 = new Profesor("Carlos", materita2);

        Estudiante estudiantito1 = new Estudiante("Ana", 10);
        Estudiante estudiantito2 = new Estudiante("Luis", 11);
        Estudiante estudiantito3 = new Estudiante("Elena", 10);

        List<Estudiante> estudiantitos1 = new List<Estudiante>();
        estudiantitos1.Add(estudiantito1);
        estudiantitos1.Add(estudiantito2);

        List<Estudiante> estudiantitos2 = new List<Estudiante>();
        estudiantitos2.Add(estudiantito3);

        Aula aulita1 = new Aula("Aula 1",profesorcito1, estudiantitos1);
        Aula aulita2 = new Aula("Aula 2",profesorcito2, estudiantitos2);

        List<Aula> aulitas = new List<Aula>();
        aulitas.Add(aulita1);
        aulitas.Add(aulita2);
        
        Escuela escuelita = new Escuela("Escuela Angelitos", aulitas, administradorcito);

        administradorcito.MostrarDetalles();
        materita1.MostrarDetalles();
        materita2.MostrarDetalles();
        profesorcito1.MostrarDetalles();
        profesorcito2.MostrarDetalles();
        estudiantito1.MostrarDetalles();
        estudiantito2.MostrarDetalles();
        estudiantito3.MostrarDetalles();
        aulita1.MostrarDetalles();
        aulita2.MostrarDetalles();
        escuelita.MostrarDetalles();
    }
}