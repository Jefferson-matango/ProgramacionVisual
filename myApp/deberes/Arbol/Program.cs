using System.Collections.Generic;
using System;
namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MediosTransporte mediosTransporte = new MediosTransporte ();
            mediosTransporte.Nombre = "MasUsados";
            mediosTransporte.TipoTransporte = TipoTransporte.Transportes;
            mediosTransporte.MediosTransportes = new List <MediosTransporte>
            {
                new MediosTransporte
                {
                    Nombre = "PorTierra",
                    TipoTransporte.Terrestres,
                    MediosTransportes = new List <MediosTransporte>
                    {
                        new MediosTransporte
                        {
                            Nombre = "Carro",
                            TipoTransporte.Motor,
                            MediosTransportes = new List <MediosTransporte>
                            {
                                new MediosTransporte
                                {
                                    Nombre = "Mazda",
                                    TipoTransporte.Marca,
                                    Usados = 9
                                };
                            };
                        };

                        new MediosTransporte
                        {
                            Nombre = "Bicicleta",
                            TipoTransporte.NoMotor,
                            MediosTransportes = new List <MediosTransporte>
                            {
                                new MediosTransporte
                                {
                                    Nombre = "Merida",
                                    TipoTransporte.Marca,
                                    Usados = 8
                                };
                            };
                        }
                    }
                };
                new MediosTransporte
                {
                    Nombre = "PorMar",
                    TipoTransporte.Maritimos,
                    MediosTransportes = new List <MediosTransporte>
                    {
                        new MediosTransporte
                        {
                            Nombre = "Lancha",
                            TipoTransporte.Motor,
                            MediosTransportes = new List <MediosTransporte>
                            {
                                new MediosTransporte
                                {
                                    Nombre = "Advantage",
                                    TipoTransporte.Marca,
                                    Usados=7
                                };
                            };
                        };

                        new MediosTransporte
                        {
                            Nombre = "Barco",
                            TipoTransporte.NoMotor,
                            MediosTransportes = new List <MediosTransporte>
                            {
                                new MediosTransporte
                                {
                                    Nombre = "SantaMonica",
                                    TipoTransporte.Marca,
                                    Usados=1
                                }
                            }
                        };
                    }
                };
            };
            Console.WriteLine(mediosTransporte.NumeroMasUsado());
        }
    }
}