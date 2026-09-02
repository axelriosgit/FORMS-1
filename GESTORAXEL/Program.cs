using System;

namespace GestorProductos;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        
        var controller = new ProductoController();

      
        Application.Run(new Form1(controller));
    }
}