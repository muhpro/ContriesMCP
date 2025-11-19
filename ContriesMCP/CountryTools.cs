using System.ComponentModel;
using ModelContextProtocol.Server;

namespace ContriesMCP
{
    [McpServerToolType]
    public class CountryTools
    {
        private static CountryService _countryService = new CountryService();

        [McpServerTool, Description("Get all countries.")]
        public static async Task<List<Country>> GetAllCountriesAsync()
        {
            return await _countryService.GetAllCountriesAsync();
        }

        [McpServerTool, Description("Get country by name.")]
        public static async Task<Country?> GetCountryByNameAsync(string name)
        {
            return await _countryService.GetCountryByNameAsync(name);
        }
    }
}