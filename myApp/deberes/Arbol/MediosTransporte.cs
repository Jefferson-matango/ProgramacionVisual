using System.Collections.Generic;
using System.Linq;
namespace myApp
{
    internal class MediosTransporte
    {
        public int Id {get; set; }
        public String Nombre {get; set; }
        public String TipoTransporte {get; set; }
        public int Usados {get; set; }
        public List <MediosTransporte> MediosTransportes {get; set; } = new List <MediosTransporte>();
        public int NumeroMasUsado()
        {
            if(!MediosTransportes.Any())
                return 0;
            else
            {
                int acumulador = 0;
                foreach (MediosTransporte actual in MediosTransportes)
                    acumulador += actual.NumeroMasUsado();
                
                return acumulador;
            }
        }
    }
}