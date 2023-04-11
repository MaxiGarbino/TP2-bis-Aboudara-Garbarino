using System;
class Boxeador
{
    // Definicion de Propiedades
    public string Nombre{get;set;}
    public string Pais{get;set;}
    public int Peso{get;set;}
    public int PotenciaGolpes{get;set;}
    private int VelocidadPiernas{get;set;}
// Constructor
public Boxeador()
{

}
    public Boxeador(string nom = "", string pais="", int peso=0, int pg = 0, int vp = 0)
    {
        Nombre = nom;
        Pais = pais;
        Peso=peso;
        PotenciaGolpes = pg;
        VelocidadPiernas = 0;
    }

    // Métodos

    public int MiEdad()
    {
        DateTime FechaNacimientoHoy = new DateTime(DateTime.Today.Year, FechaNacimiento.Month, FechaNacimiento.Day);
        if (FechaNacimientoHoy< DateTime.Today)  Edad = DateTime.Today.Year - FechaNacimiento.Year;
            else   Edad = DateTime.Today.Year - FechaNacimiento.Year -1;
        return Edad; 
    }
}