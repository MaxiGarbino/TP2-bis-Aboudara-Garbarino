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
    public Boxeador(string nom = "", string pais="", int peso=0, int pg = 0, int vp = 0)
    {
        Nombre = nom;
        Pais = pais;
        Peso=peso;
        PotenciaGolpes = pg;
        VelocidadPiernas = vp;
    }

    // Métodos

    public double ObtenerSkill()
    {
        double skill = 0;
        skill = PotenciaGolpes * 0.6 + VelocidadPiernas * 0.8 + Funciones.ObtenerRandom(1,10);  
        return skill;
    }
}