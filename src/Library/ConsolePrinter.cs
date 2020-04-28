using System;

// Lo que hice fue hacer uuna de las implementaciones del tipo IPrinter definido en la interfase.
// Se recibe una receta como parámetro y se implementa el método PrintRecipe para 
// escribir en pantalla.

// Los comentarios en IPrinter explican cómo se trabajó.
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}
