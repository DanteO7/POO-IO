namespace Escuela.Modelos;
    class Program
    {
        static void Main()
        {
            Escuela escuelita = new Escuela("Escuela Angelitos", new Administrador("Juan Perez", 15));
            
            Profesor profesorcito1 = new Profesor("Maria");

            profesorcito1.Añadir(new Materia("Matematica", 5));
            profesorcito1.Añadir(new Materia("Historia", 3));

            Aula aulita1 = new Aula("Aula 1", profesorcito1);
            aulita1.Añadir(new Estudiante("Ana", 10));
            aulita1.Añadir(new Estudiante("Luis", 11));

            Profesor profesorcito2 = new Profesor("Carlos Garcia");
            profesorcito2.Añadir(new Materia("Ciencia", 4));

            Aula aulita2 = new Aula ("Aula 2", profesorcito2);
            aulita2.Añadir(new Estudiante("Elena", 10));

            escuelita.Añadir(aulita1);
            escuelita.Añadir(aulita2);

            escuelita.MostrarDetalles();

            Console.WriteLine("-------------------------------------------------------");

            Proyecto proyectito1 = new Proyecto("Proyecto de Ciencias", "Investigacion sobre la energia solar");
            Evaluador evualuadorcito1 = new Evaluador("Sofia Alcaraz", "Matemática");
            
            proyectito1.EvaluarProyecto(evualuadorcito1);
    }
}