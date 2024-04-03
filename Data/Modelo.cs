
public class Casos
{
    public string Id {get; set;} = String.Empty;
    public DateTime Fecha {get; set;} = DateTime.Now;
    public string Cliente {get; set;} = String.Empty;
    public string TipoCaso {get; set;} = String.Empty;
    public string Ubicacion {get; set;} = String.Empty;
    public string Descripcion {get; set;} = String.Empty;
    public string Abogado {get; set;} = String.Empty;
    public string EstadoCaso {get; set;} = String.Empty;
}

public class Cliente
{
    public string Id {get; set;} = String.Empty;
    public string Nombre {get; set;} = String.Empty;
    public string Apellido {get; set;} = String.Empty;
    public string Correo {get; set;} = String.Empty;
    public int Telefono {get; set;} = 0;
    public int Celular {get; set;} = 0;
    public string Direccion {get; set;} = String.Empty;
    public string EstadoCivil {get; set;} = String.Empty;
}

public class Abogado
{
    public string Id {get; set;} = String.Empty;
    public string UserName {get; set;} = String.Empty;
    public string Password {get; set;} = String.Empty;
}

