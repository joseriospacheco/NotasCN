namespace NotasCN.Application;
using NotasCN.Domain.Entities;

internal class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Ingrese las notas (0 - 5.0):");

        Console.Write("Quiz 1: ");
        double quiz1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Idea proyecto grupal: ");
        double ideaProyectoGrupal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Parcial 1: ");
        double parcial1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Mesa de debate Avanzada: ");
        double mesaDebateAvanzada = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ajuste y desarrollo avanzado del proyecto: ");
        double ajusteDesarrolloProyecto = Convert.ToDouble(Console.ReadLine());
        Console.Write("Simulación del pitch final: ");
        double simulacionPitchFinal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Quiz 2: ");
        double quiz2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Pitch grupal final: ");
        double pitchGrupalFinal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Autoevaluación: ");
        double autoevaluacion = Convert.ToDouble(Console.ReadLine());
        Console.Write("Coevaluación: ");
        double coevaluacion = Convert.ToDouble(Console.ReadLine());

        double corte1 = Nota.CalcularPrimerCorte(quiz1, ideaProyectoGrupal, parcial1);
        double corte2 = Nota.CalcularSegundoCorte(mesaDebateAvanzada, ajusteDesarrolloProyecto, simulacionPitchFinal);
        double corte3 = Nota.CalcularTercerCorte(quiz2, pitchGrupalFinal, autoevaluacion, coevaluacion);

        double notaFinal = Nota.CalcularNotaFinal(corte1, corte2, corte3);

        Console.WriteLine($"Nota del Primer Corte: {corte1:F2}");
        Console.WriteLine($"Nota del Segundo Corte: {corte2:F2}");
        Console.WriteLine($"Nota del Tercer Corte: {corte3:F2}");
        Console.WriteLine($"Nota Final del Curso: {notaFinal:F2}");
        Console.WriteLine($"Reprobado {Nota.EstaReprobado(notaFinal)}");
    }
}
