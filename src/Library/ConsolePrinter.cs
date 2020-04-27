using System;

//---------------------------------------------------------------------------------
// ¿Qué patrón o principio usan para asignar esta responsabilidad?
//  Lo que hice fue crear tres clases ConsolePrinter, FilePrinter e IPrinter 
//  con estas clases puedo evitar preguntar por el destino de la impresión en 
//  la clase AllInOnePrinter para imprimir en diferentes destinos.
//---------------------------------------------------------------------------------
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintTicket(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}