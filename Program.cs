int opcion = Funciones.IngresarEnteroEnRango("ingrese la opcion (1, 2, 3 o 4)",1,4);
Boxeador boxeador1;
Boxeador boxeador2;
switch (opcion)
{
    case 1:
    boxeador1 = cargarDatosBoxeador();
    break;
    case 2:
    boxeador2 = cargarDatosBoxeador();
    break;
    case 3:
    //pelear();
    break;
    case 4:
    break;
    default:
    break;
}

Boxeador cargarDatosBoxeador()
{
    Boxeador boxeador;
    string nombre = Funciones.IngresarTexto("Ingrese el nombre");
    string pais = Funciones.IngresarTexto("Ingrese el pais");
    int peso = Funciones.IngresarEntero("Igrese el peso");
    int potenciaGolpes = Funciones.IngresarEntero("Ingrese la potencia de los golpes");
    int velocidadPiernas = Funciones.IngresarEntero("Ingrese la velocidad de las piernas");
    boxeador = new Boxeador(nombre, pais, peso, potenciaGolpes, velocidadPiernas);
    return boxeador;
}

