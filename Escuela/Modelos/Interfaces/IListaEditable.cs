namespace Escuela.Modelos.Interfaces
{
    public interface IListaEditable<T> where T : class
    {
        void Añadir(T entidad);
        void Quitar(T entidad);
    }
}
