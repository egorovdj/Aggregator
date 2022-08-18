namespace Aggregator.Data
{
    public class TypesOfAggregatorCars
    {
        static readonly Dictionary<string, List<string>> typesOfCars = new()
        {
            {"Яндекс.Такси", new List<string> { "Эконом", "Комфорт", "Бизнес", "Премиум" } },
            {"Uber", new List<string> { "UberX", "UberSelect", "UberBlack" } },
            {"Ситимобил", new List<string> { "эконом", "комфорт", "бизнес" } },
            {"Максим", new List<string> { "Эконом", "Комфорт", "Бизнес" } }
        };

        public static Task<string[]> GetAggregatorAsync()
        {
            return Task.FromResult(typesOfCars.Keys.ToArray());
        }

        public static Task<string[]> GetTypesOfCarsAsync(string aggr)
        {
            return Task.FromResult(typesOfCars[aggr].ToArray());
        }
        public static string Theme = "https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css";
    }
}
