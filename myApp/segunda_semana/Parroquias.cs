namespace segunda_semana
{
    class Parroquias
    {
        public int ParroquiasId
        {
            get;set;
        }
        public string Nombre
        {
            get;set;
        }
        public int Habitantes{get;set;}
        public int ObetenerNumeroDeHabitantes()
    {
        int acumulador=0;
        foreach (Provincia actual in Provincias)
        {
            acumulador=acumulador+actual.Habitantes();
        }
        return acumulador;
    }
    }
}