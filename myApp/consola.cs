using System;
namespace myApp
{
    class Program
    {
        class datosPersonales
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Bienvenido por favor ingresa tus datos para continuar");
                if (args.Length > 0)
                {
                    //1
                    Console.Write("¿Como te llamas?");
                    String nombre = Console.ReadLine();
                    //2
                    Console.Write("¿Cuantos años tienes?");
                    while (true)
                    {
                        var edad = Console.ReadLine();
                        if (!int.TryParse(edad,out int edadP))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //3
                    Console.Write("¿Que año naciste?");
                    while (true)
                    {
                        var anio = Console.ReadLine();
                        if (!int.TryParse(anio,out int anioP))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //4
                    Console.Write("¿Cuanto mides?");
                    while (true)
                    {
                        var estatura = Console.ReadLine();
                        if (!int.TryParse(estatura,out int estaturaP))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //5
                    Console.Write("¿Cuanto pesas?");
                    while (true)
                    {
                        var peso = Console.ReadLine();
                        if (!int.TryParse(peso,out int pesoP))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //6
                    Console.Write("¿Cual es tu numero de telefono?");
                    while (true)
                    {
                        var telefono = Console.ReadLine();
                        if (!int.TryParse(telefono,out int telefonoP))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //7
                    Console.Write("¿Cual es tu dirección?");
                    String direccion = Console.ReadLine();
                    //8
                    Console.Write("¿Con cuantas personas vives?");
                    while (true)
                    {
                        var people = Console.ReadLine();
                        if (!int.TryParse(people,out int peopleP))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //9
                    Console.Write("Comprobando datos ingresados");
                    bool acceso = true;
                    Console.Write("Datos comprobados" + acceso);
                    //10
                    //Console.WriteLine("Datos ingresados el " + DateTime.Now);
                    //Console.WriteLine("A ingresado los siguientes datos: ");
                    //Console.WriteLine($"Nombre: {nombre}");
                    //Console.WriteLine($"Edad:  {edad}");
                    //Console.WriteLine($"Año de nacimiento: {anioP}");
                    //Console.WriteLine($"Peso: {pesoP}");
                    //Console.WriteLine($"Estatura: {estaturaP}");
                    //Console.WriteLine($"telefono: {telefonoP}");
                    //Console.WriteLine($"Direccion: {direccion}");
                    //Console.WriteLine($"people: {peopleP}");
                    
                }
                else
                {
                    Console.WriteLine("No se lo pudo identificar");
                }
            }
        }

        class pelicula 
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Bienvenido por favor ingresa una pelicula");
                if (args.Length > 0)
                {
                    //1
                    Console.Write("¿Cual es el titulo?");
                    String nombre = Console.ReadLine();
                    //2
                    Console.Write("¿De que año es?");
                    while (true)
                    {
                        var edad = Console.ReadLine();
                        if (!int.TryParse(edad,out int edadP))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //3
                    Console.Write("¿Cuando se estreno?");
                    while (true)
                    {
                        var anio = Console.ReadLine();
                        if (!int.TryParse(anio,out int anioP))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //4
                    Console.Write("¿Cuanto dura?");
                    while (true)
                    {
                        var duracion = Console.ReadLine();
                        if (!int.TryParse(duracion,out int Duracion))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //5
                    Console.Write("¿Cuantos actores tiene?");
                    while (true)
                    {
                        var actores = Console.ReadLine();
                        if (!int.TryParse(actores,out int Actores))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //6
                    Console.Write("¿Quien es el director?");
                    String director = Console.ReadLine();
                    //7
                    Console.Write("¿Donde se grabo?");
                    String direccion = Console.ReadLine();
                    //8
                    Console.Write("¿Cuantas personas trabajaron?");
                    while (true)
                    {
                        var people = Console.ReadLine();
                        if (!int.TryParse(people,out int peopleP))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //9
                    Console.Write("Comprobando datos ingresados");
                    bool acceso = true;
                    Console.Write("Datos comprobados" + acceso);
                }
                else
                {
                    Console.WriteLine("No se ingreso ningun dato");
                }
            }
        }
        class videojuego 
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Bienvenido por favor ingresa su videojuego favorito");
                if (args.Length > 0)
                {
                    //1
                    Console.Write("¿Cual es el nombre?");
                    String nombre = Console.ReadLine();
                    //2
                    Console.Write("¿Que año se realizo?");
                    while (true)
                    {
                        var edad = Console.ReadLine();
                        if (!int.TryParse(edad,out int edadP))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //3
                    Console.Write("¿Que año salio a la venta?");
                    while (true)
                    {
                        var anio = Console.ReadLine();
                        if (!int.TryParse(anio,out int anioP))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //4
                    Console.Write("¿Cuantas horas de juego tiene?");
                    while (true)
                    {
                        var duracion = Console.ReadLine();
                        if (!int.TryParse(duracion,out int Duracion))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //5
                    Console.Write("¿Cuantos diseñadores trabajaron?");
                    while (true)
                    {
                        var diseniadores = Console.ReadLine();
                        if (!int.TryParse(diseniadores,out int Diseniadores))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //6
                    Console.Write("¿Quien es el publisher?");
                    String publisher = Console.ReadLine();
                    //7
                    Console.Write("¿En que estudio se realizo?");
                    String estudio = Console.ReadLine();
                    //8
                    Console.Write("¿Cuantas personas trabajaron?");
                    while (true)
                    {
                        var people = Console.ReadLine();
                        if (!int.TryParse(people,out int peopleP))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //9
                    Console.Write("Cuantas actores participaron");
                    string actores = Console.ReadLine();
                    //10
                    Console.Write("Comprobando datos ingresados");
                    bool acceso = true;
                    Console.Write("Datos comprobados" + acceso);
                }
                else
                {
                    Console.WriteLine("No se ingreso ningun dato");
                }
            }
        }
        class anime 
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Bienvenido por favor ingresa su anime favorito");
                if (args.Length > 0)
                {
                    //1
                    Console.Write("¿Cual es el nombre?");
                    String nombre = Console.ReadLine();
                    //2
                    Console.Write("¿En que año se lanzo el trailer?");
                    while (true)
                    {
                        var edad = Console.ReadLine();
                        if (!int.TryParse(edad,out int edadP))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //3
                    Console.Write("¿Que año se estreno?");
                    while (true)
                    {
                        var anio = Console.ReadLine();
                        if (!int.TryParse(anio,out int anioP))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //4
                    Console.Write("¿Cuantos capitulos contiene?");
                    while (true)
                    {
                        var capitulos = Console.ReadLine();
                        if (!int.TryParse(capitulos,out int Capitulos))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //5
                    Console.Write("¿Cuanto dura cada episodio?");
                    while (true)
                    {
                        var duracion = Console.ReadLine();
                        if (!int.TryParse(duracion,out int Duracion))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //6
                    Console.Write("¿Quien lo produjo?");
                    String productora = Console.ReadLine();
                    //7
                    Console.Write("¿En que televisora se estrenó?");
                    String estudio = Console.ReadLine();
                    //8
                    Console.Write("¿Cuantos actores de voz trabajaron?");
                    while (true)
                    {
                        var people = Console.ReadLine();
                        if (!int.TryParse(people,out int peopleP))
                        {
                            Console.Write("Ingrese un valor numerico");
                        }
                        else
                        {
                            break;
                        };
                    };
                    //9
                    Console.Write("Comprobando datos ingresados");
                    bool acceso = true;
                    Console.Write("Datos comprobados" + acceso);
                }
                else
                {
                    Console.WriteLine("No se ingreso ningun dato");
                }
            }
        }
    }
}
