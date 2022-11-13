//Lucía Rodas 1232222
//Luis Pedro Rubio 1148822
string opcionIngresada = "";
string usuario = "";
int tempProm = 0;
int tempMax;
int tempMin;
int sumaTemps = 0;
Console.WriteLine("Ingrese su el nombre de usuario");
usuario = Console.ReadLine();
Console.WriteLine("Panel de Control");
Console.WriteLine("Bienvenido " + usuario +" Elija una opción");
Console.WriteLine("Opcion 1 ----> Ventilación");
Console.WriteLine("OPcion 2 ----> Calefacción");
Console.WriteLine("Opcion 3 ----> Usuario");
opcionIngresada = Console.ReadLine();

switch (opcionIngresada)
{
    case "1":
        Console.WriteLine("Endecender ventilación: ");
        Console.WriteLine("Ingrese la hora que desee activar la ventilación");
        int horaProgramada = 0;
        horaProgramada = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Ingrese la hora que desee desactivar la ventilación");
        int horaProgramApagar = 0;
        horaProgramApagar = Convert.ToInt32(Console.ReadLine());
        if (horaProgramada >= 0 && horaProgramada <= 24)
        {
            if (horaProgramApagar > horaProgramada && horaProgramApagar < 24)
            {
                Console.WriteLine("Ventilación se encenderá a " + horaProgramada + "  horas Y se apagará a " + horaProgramApagar + "horas");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        else
        {
            Console.WriteLine("Error");
        }
        break;


    case "2":
        Console.WriteLine("Ingrese temperatura mínima deseada: ");
        tempMin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese temperatura máxima deseada: ");
        tempMax = Convert.ToInt32(Console.ReadLine());
        if (tempMin >= 18 && tempMin < 22)
        {
            if (tempMax <= 22)
            {
                sumaTemps = tempMin + tempMax;
                tempProm = sumaTemps / 2;
                Console.WriteLine("La temperatura promedio es de " + tempProm);
            }
            if (tempMax > 22)
            {
                Console.WriteLine("Temperatura máxima sobrepasa el límite de 22°C");
            }
            if (tempMax <= tempMin)
            {
                Console.WriteLine("Temperatura máxima es menor o igual que máxima");
            }
        }
        if (tempMin < 18)
        {
            Console.WriteLine("Temperatura mínima está abajo del rango permitido de 18°C");
        }
        if (tempMin >= tempMax)
        {
            Console.WriteLine("Temperatura mínima es mayor o igual que temperatura máxima");
        }
        
        
        break;

    case "3":
        Console.WriteLine("DATOS DE USUARIO");
        Console.WriteLine("Nombre de usuario: ");
        Console.WriteLine(usuario);
        Console.WriteLine("Bio");
        string Bio;
        Bio = Console.ReadLine();
        Console.WriteLine("Edad");
        int edad;
        edad = Convert.ToInt32(Console.ReadLine());

        break;
    default:
        Console.WriteLine("Ups!");
        break;
}


