using APIpeliculas.Models;

namespace APIpeliculas.Repositorio.IRepositorio
{
    public interface ICategoriaRepositorio
    {
        ICollection<Categoria> GetCategorias();
        Categoria GetCategoria(int categoriaId);
        bool ExisteCategoria(int CategoriaId);
        bool ExisteCategoria(int id);
        bool ExisteCategoria(string nombre);

        bool CrearCategoria(Categoria categoria);
        bool ActualizarCategoria(Categoria categoria);
        bool BorrarCategoria(Categoria categoria);
        bool Guardar();

    }
}
