namespace Escuela.Modelos
{
    public class EntidadConNombre : Interfaces.IMostrable
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
        public EntidadConNombre(string nombre)
        {
            Nombre = nombre;
        }
        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}");
        }
    }
}
