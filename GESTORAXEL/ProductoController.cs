using System;
using System.Collections.Generic;
using System.Linq;

namespace GestorProductos;

public class ProductoController
{
    private readonly IRepository<Producto> _repo;

    public ProductoController(IRepository<Producto> repo)
    {
        _repo = repo;
    }

    public void Agregar(string nombre, decimal precio, int stock, string rubro)
    {
        var producto = new Producto
        {
            Nombre = nombre,
            Precio = precio,
            Stock = stock,
            Rubro = rubro
        };

        _repo.Agregar(producto);
    }

    public List<Producto> ObtenerTodos()
    {
        return _repo.LeerTodos();
    }

    public void Eliminar(int id)
    {
        _repo.Eliminar(id);
    }

    public void Modificar(Producto modificado)
    {
        _repo.Actualizar(modificado);
    }

    public void EliminarSegunStock(int stockMaximo)
    {
        var lista = _repo.LeerTodos();
        var paraEliminar = lista.Where(p => p.Stock <= stockMaximo).ToList();

        foreach (var p in paraEliminar)
        {
            _repo.Eliminar(p.Id);
        }
    }

    public List<Producto> Buscar(string texto)
    {
        texto = texto.Trim();
        var todos = _repo.LeerTodos();

        if (string.IsNullOrWhiteSpace(texto))
        {
            return todos;
        }

        return todos
            .Where(p => p.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                        p.Rubro.Contains(texto, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}