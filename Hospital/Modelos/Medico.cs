namespace Hospital.Modelos
{
    public class Medico
    {
        public string Nombre { get; set; }
        public Especializacion Especializacion { get; set; }
        private List<Paciente> _pacientes;
        public Medico(string nombre, Especializacion especializacion)
        {
            Nombre = nombre;
            Especializacion = especializacion;
            _pacientes = new List<Paciente>();
        }
        public void AtenderPaciente(Paciente paciente)
        {
            _pacientes.Add(paciente);
            paciente.Visitas++;
        }
        public List<Paciente> ObtenerPacientes() => _pacientes;
        public HistorialMedico ObtenerHMPaciente(Paciente paciente)
        {
            return paciente.ObtenerHistorial();
        }
    }
}
