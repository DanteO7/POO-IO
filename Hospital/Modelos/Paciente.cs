namespace Hospital.Modelos
{
    public class Paciente
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Visitas { get; set; } = 0;
        public HistorialMedico HistorialPaciente { get; set; }
        public Paciente(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
            HistorialPaciente = new HistorialMedico();
        }
        public HistorialMedico ObtenerHistorial() => HistorialPaciente;
    }
}
/*
funcion flecha en javascript
    funcion landa en c#
*/