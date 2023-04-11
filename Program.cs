int opcion = Funciones.IngresarEnteroEnRango("ingrese la opcion (1, 2, 3 o 4)",1,4);
Boxeador boxeador1 = new Boxeador();
switch (opcion)
{
    case 1:
    cargarDatosBoxeador1();
    break;
    case 2:
    cargarDatosBoxeador2();
    break;
    case 3:
    pelear();
    break;
    case 4:
    break;
    default:
    break;
}

void cargarDatosBoxeador1()
{
    Console.WriteLine("BOXEADOR 1");
    /*
    Nombre = nom;
        Pais = pais;
        Peso=peso;
        PotenciaGolpes = pg;
        VelocidadPiernas = vp;
    }
    */
    string nombre = Funciones.IngresarTexto("Ingrese el nombre");
    string pais = Funciones.IngresarTexto("Ingrese el pais");
    int peso = Funciones.IngresarEntero("Igrese el peso");
}

