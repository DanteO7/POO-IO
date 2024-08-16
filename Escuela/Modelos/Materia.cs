namespace Escuela.Modelos
{
    public class Materia : EntidadConNombre
    {
        private int _credito;
        public int Creditos
        {
            get { return _credito; }
            set
            {
                if (value >= 0)
                {
                    _credito = value;
                }
                else
                {
                    throw new ArgumentException("Los creditos no deben ser negativos");
                }
            }
        }
        public Materia(string nombre, int credito) : base(nombre)
        {
            Creditos = credito;
        }
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Creditos: {Creditos}\n");
        }
    }
}
