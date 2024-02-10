namespace ApiCrud.api.Estudantes;

public static class EstudantesRotas
{
    public static void AddRotasEstudantes(this WebApplication app)
    {
        app.MapGet("estudantes", () => new Estudante("Ygor"));
    }
}