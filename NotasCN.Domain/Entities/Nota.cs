using NotasCN.Domain.Exceptions;

namespace NotasCN.Domain.Entities;

public class Nota
{

    public static double CalcularPrimerCorte(double quiz1, double ideaProyectoGrupal, double parcial1)
    {
        quiz1 = ValidarNota(quiz1);
        ideaProyectoGrupal = ValidarNota(ideaProyectoGrupal);
        parcial1 = ValidarNota(parcial1);
        return (quiz1 * 0.10 + ideaProyectoGrupal * 0.05 + parcial1 * 0.15) / 0.3;
    }

    public static double CalcularSegundoCorte(double mesaDebateAvanzada, double ajusteDesarrolloProyecto, double simulacionPitchFinal)
    {
        mesaDebateAvanzada = ValidarNota(mesaDebateAvanzada);
        ajusteDesarrolloProyecto = ValidarNota(ajusteDesarrolloProyecto);
        simulacionPitchFinal = ValidarNota(simulacionPitchFinal);
        return (mesaDebateAvanzada * 0.05 + ajusteDesarrolloProyecto * 0.20 + simulacionPitchFinal * 0.05) / 0.3;
    }

    public static double CalcularTercerCorte(double quiz2, double pitchGrupalFinal, double autoevaluacion, double coevaluacion)
    {
        quiz2 = ValidarNota(quiz2);
        pitchGrupalFinal = ValidarNota(pitchGrupalFinal);
        autoevaluacion = ValidarNota(autoevaluacion);
        coevaluacion = ValidarNota(coevaluacion);
        return (quiz2 * 0.10 + pitchGrupalFinal * 0.20 + autoevaluacion * 0.05 + coevaluacion * 0.05) / 0.4;
    }

    public static double CalcularNotaFinal(double corte1, double corte2, double corte3)
    {
        return corte1 * 0.30 + corte2 * 0.30 + corte3 * 0.40;
    }

    private static double ValidarNota(double nota)
    {
        if (nota < 0 || nota > 5)
        {
            throw new BusinessRuleException("La nota debe estar entre 0 y 5.");
        }
        return nota;
    }

    public static bool EstaReprobado(double notaFinal)
    {
        return notaFinal < 3;
    }

}
