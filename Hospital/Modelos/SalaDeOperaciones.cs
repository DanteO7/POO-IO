namespace Hospital.Modelos
{
    public class SalaDeOperaciones
    {
        public int NumeroDeSala {  get; set; }
        public SalaDeOperaciones(int numeroDeSala)
        {
            NumeroDeSala = numeroDeSala;
        }
        public void ReservarSala()
        {
            Console.WriteLine($"Sala {NumeroDeSala} Reservada");
        }
    }
}
