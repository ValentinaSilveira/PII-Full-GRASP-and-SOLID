using System;
// Se borró la clase AllInOnePrinter dado que era código redundante con los cambios realizados.
// Se implementó que el método PrintRecipe sea polimórfico para imprimir por consola o archivo.
// Se creó la interfase IPrinter dado que se establece un tipo en común para la impresión
// en cualquiera de las dos clases.

// Se utilizó el patrón Polymorphism. Ambos tipos de clases no interfieren, de manera que
// no dan resultados inesperados. Se cumple el principio de sustitución de Liskov.


namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
    void PrintRecipe(Recipe recipe);
    }
}