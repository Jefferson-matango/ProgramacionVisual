namespace segunda_semana
{
    class pais
    {
        public int PaisId{get; set;}
        public string Nombre{get;set;}
        public List <Provincia> Provincias{get;set;}
    }
    public int ObetenerNumeroDeHabitantes()
    {
        int acumulador=0;
        foreach (Provincia actual in Provincias)
        {
            acumulador=acumulador+actual.ObetenerNumeroDeHabitantes();
        }
        return acumulador;
    }
}