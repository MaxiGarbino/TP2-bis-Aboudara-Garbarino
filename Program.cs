
Boxeador boxeador1 = new Boxeador();
Boxeador boxeador2 = new Boxeador();
int opcion;
bool box1 = false,box2 = false;
do
{
    
    opcion = Funciones.IngresarEnteroEnRango("ingrese la opcion (1, 2, 3 o 4) ",1,4);
    switch (opcion)
    {
    case 1:
    boxeador1 = cargarDatosBoxeador();
    box1 = true;
    break;
    case 2:
    boxeador2 = cargarDatosBoxeador();
    box2 = true;
    break;
    case 3:
    if(box1 && box2) pelear();
    else Console.WriteLine("No se ingreso alguno de los boxeadores");
    break;
    case 4:
    Console.WriteLine("SALIENDO");
    break;
}
}while(opcion != 4);

Boxeador cargarDatosBoxeador()
{
Boxeador boxeador;
string nombre = Funciones.IngresarTexto("Ingrese el nombre ");
string pais = Funciones.IngresarTexto("Ingrese el pais ");
int peso = Funciones.IngresarEntero("Igrese el peso ");
int potenciaGolpes = Funciones.IngresarEntero("Ingrese la potencia de los golpes ");
int velocidadPiernas = Funciones.IngresarEntero("Ingrese la velocidad de las piernas ");
boxeador = new Boxeador(nombre, pais, peso, potenciaGolpes, velocidadPiernas);
return boxeador;
}
void pelear(){
    
    
        double difSkill = 0;
        string nombreGanador = "";
        double skill1,skill2;
        skill1 = boxeador1.ObtenerSkill();
        skill2 = boxeador2.ObtenerSkill();
    
        if (skill1 < skill2) {
            difSkill = skill2 - skill1;
            nombreGanador = boxeador2.Nombre;
            }
        else{ 
            difSkill = skill1 - skill2;
            nombreGanador = boxeador1.Nombre;
        }
        if (difSkill >= 30)Console.WriteLine("Ganó "+ nombreGanador+" por KO");
        else if (difSkill >= 10)Console.WriteLine("Ganó "+ nombreGanador+" por puntos en fallo unanime");
        else if (difSkill < 10 && difSkill > 0)Console.WriteLine("Ganó "+ nombreGanador+" por puntos en fallo dividido");
        else Console.WriteLine("Empate");
    }
