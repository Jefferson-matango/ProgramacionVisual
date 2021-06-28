using System;
namespace segunda_semana
{
    class Program
    {
        static void Main(string[]args)
        {
            //var pais= "Ecuador";
            Pais a = new pais
            {
                Nombre="Ecuador",
                PaisId="1"
            }; // mal ejemplo es la "a"de nombre de una variable
            Pais pais1; // asi se debe declarar variables
            //var pais2; no se debe declarar asi las variables 
            var Ecuador= new Pais();//inferencia    se puede usar cualquiera
            pais.Nombre = "Ecuador";
            pais.Provincias= new list <Provincia> ();
            var Provincia1 = new Provincia();
            Provincia1.Nombre="Guayas";
            Provincia1.Cantones=new List <Canton> ();
            Provincia1.Cantones.add(canton1);
            canton1.Parroquias=new list<Parroquia>();
            canton1.Parroquia.add(parroquia1);
            var Provincia1 = new Provincia();
            Provincia1.Nombre="Galapagos";
            var Provincia1 = new Provincia();
            Provincia1.Nombre="Loja";

            pais.Provincias= new list <Provincia> ()
            {
                Provincia1,
                Provincia2,
                Provincia3,
            };
        }
    }
}