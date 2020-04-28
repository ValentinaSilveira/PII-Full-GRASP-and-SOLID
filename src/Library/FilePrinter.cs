using Full_GRASP_And_SOLID.Library;
using System.IO;
// Aquí lo que se hace es una de las implementaciones del tipo IPrinter definido en la interfase.
// Se recibe una receta como parámetro y se implementa el método PrintRecipe para escribir
// un txt.

// Los comentarios en IPrinter explican cómo se trabajó.


namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Ticket.txt", recipe.GetTextToPrint());
        }
    }
}
