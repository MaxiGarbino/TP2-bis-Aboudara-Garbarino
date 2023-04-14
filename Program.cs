int opcion = Funciones.IngresarEnteroEnRango("ingrese la opcion (1, 2, 3 o 4)",1,4);
Boxeador boxeador1;
Boxeador boxeador2;
switch (opcion)
{
    case 1:
    cargarDatosBoxeador(ref boxeador1);
    break;
    case 2:
    cargarDatosBoxeador(ref boxeador2);
    break;
    case 3:
    pelear();
    break;
    case 4:
    break;
    default:
    break;
}

void cargarDatosBoxeador(ref Boxeador boxeador)
{
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
    int potenciaGolpes = Funciones.IngresarEntero("Ingrese la potencia de los golpes");
    int velocidadPiernas = Funciones.IngresarEntero("Ingrese la velocidad de las piernas")
    boxeador = new Boxeador(nombre, pais, peso, potenciaGolpes, velocidadPiernas);
}

