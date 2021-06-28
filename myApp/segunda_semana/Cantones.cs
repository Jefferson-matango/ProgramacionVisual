namespace segunda_semana
{
    class Canton
    {
        public int CantonesId
        {
            get;set;
        }
        public string Nombre
        {
            get;set;
        }
        public List <Parroquia> Parroquias{get;set;}
        public int ObetenerNumeroDeHabitantes()
    {
        int acumulador=0;
        foreach (Parroquia actual in Parroquias)
        {
            acumulador=acumulador+actual.ObetenerNumeroDeHabitantes();
        }
        return acumulador;
    }
    }
}