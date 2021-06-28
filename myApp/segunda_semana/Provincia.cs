namespace segunda_semana
{
    class provincia
    {
        public int ProvinciaId
        {
            get;set;
        }
        public string Nombre
        {
            get;set;
        }
        public List <Canton> Cantones{get;set;}
        public int ObetenerNumeroDeHabitantes()
    {
        int acumulador=0;
        foreach (Canton actual in Cantones)
        {
            acumulador=acumulador+actual.ObetenerNumeroDeHabitantes();
        }
        return acumulador;
    }
    }
}