using Escuela.Modelos.Interfaces;

namespace Escuela.Modelos
{
    public class Profesor : EntidadConNombre, IListaEditable<Materia>
    {
        private List<Materia> _materias = new List<Materia>();
        public List<Materia> Materias { get { return _materias; } }
        public Profesor(string nombre) : base(nombre) { }
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Materia: ");
            foreach (var materia in _materias)
            {
                materia.MostrarDetalles();
            }

            Console.WriteLine("\n");
        }
        public void Añadir(Materia entidad)
        {
            _materias.Add(entidad);
        }
        public void Quitar(Materia entidad)
        {
            _materias.Remove(entidad);
        }
    }
}
