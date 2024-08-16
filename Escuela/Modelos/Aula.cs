using Escuela.Modelos.Interfaces;

namespace Escuela.Modelos
{
    public class Aula : EntidadConNombre, IListaEditable<Estudiante>
    {
        public Profesor Profesor { get; set; }
        private List<Estudiante> _estudiantes = new List<Estudiante>();
        public List<Estudiante> Estudiantes { get { return _estudiantes; } }
        public Aula(string nombre, Profesor profesor) : base(nombre)
        {
            Profesor = profesor;
        }
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Profesor.MostrarDetalles();
            Console.WriteLine($"Estudiantes: ");
            foreach (var estudiante in _estudiantes)
            {
                estudiante.MostrarDetalles();
            }
            Console.WriteLine("\n");
        }
        public void Añadir(Estudiante entidad)
        {
            _estudiantes.Add(entidad);
        }
        public void Quitar(Estudiante entidad)
        {
            _estudiantes.Remove(entidad);
        }
    }
}
