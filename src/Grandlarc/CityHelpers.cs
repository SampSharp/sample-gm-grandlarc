namespace Grandlarc
{
    public static class CityHelpers
    {
        public static City Next(this City current)
        {
            return current switch
            {
                City.LosSantos => City.SanFierro,
                City.SanFierro => City.LasVenturas,
                City.LasVenturas => City.LosSantos,
                _ => City.LosSantos
            };
        }

        public static City Previous(this City current)
        {
            return current switch
            {
                City.LosSantos => City.LasVenturas,
                City.SanFierro => City.LosSantos,
                City.LasVenturas => City.SanFierro,
                _ => City.LasVenturas
            };
        }
    }
}