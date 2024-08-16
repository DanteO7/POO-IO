
using Escuela.Modelos.Interfaces;

namespace Escuela.Modelos
{
    public class Escuela : EntidadConNombre, IListaEditable<Aula>
    {
        private List<Aula> _aulas = new List<Aula>();
        public List<Aula> Aulas { get { return _aulas; } }
        public Administrador Administrador { get; set; }
        public Escuela(string nombre, Administrador administrador) : base(nombre)
        {
            Administrador = administrador;
        }
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Administrador.MostrarDetalles();
            Console.WriteLine($"Aulas: ");
            foreach (var aula in _aulas)
            {
                aula.MostrarDetalles();
            }
        }
        public void Añadir(Aula entidad)
        {
            _aulas.Add(entidad);
        }
        public void Quitar(Aula entidad)
        {
            _aulas.Remove(entidad);
        }
    }
}
