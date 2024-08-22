namespace Hospital.Modelos
{
    public class Departamento
    {
        public string Nombre { get; set; }
        private List<Medico> _medicos;
        private List<Procedimiento> _procedimientos;
        private List<EquipoMedico> _equiposMedicos;
        public Departamento(string nombre)
        {
            Nombre = nombre;
            _medicos = new List<Medico>();
            _equiposMedicos = new List<EquipoMedico>();
            _procedimientos = new List<Procedimiento>();
        }
        public void AgregarMedico(Medico medico)
        {

        }
        public void AgregarProcedimiento(Procedimiento procedimiento)
        {

        }
        public void AgregarEquipoMedico(EquipoMedico equipoMedico)
        {

        }
    }
}
