namespace Hospital.Modelos
{
    class Program
    {
        static void Main()
        {
            Especializacion especializacion = new Especializacion("Cardiología");

            Hospital hospital = new Hospital("Hospital Central", "Calle Falsa 123");

            Departamento cardiologia = new Departamento("Cardiología");

            Medico drHouse = new Medico("Dr. House", especializacion);

            Paciente paciente = new Paciente("Juan Perez", 30);

            Procedimiento procedimiento = new Procedimiento("Cirugía de corazón");

            EquipoMedico equipoMedico = new EquipoMedico("Visturi", "Cortante");

            SalaDeOperaciones sala = new SalaDeOperaciones(1);

            hospital.AgregarDepa(cardiologia);

            cardiologia.AgregarMedico(drHouse);

            drHouse.AtenderPaciente(paciente);

            cardiologia.AgregarProcedimiento(procedimiento);

            procedimiento.AsignarSala(sala);

            var pacientes = drHouse.ObtenerPacientes();
            foreach (var item in pacientes)
            {
                Console.WriteLine($"{item.Nombre}, {item.Edad}");
            }
        }
    }
}
