namespace ContriesMCP
{
    public class CountryService
    {
        HttpClient _httpClient;

        public CountryService()
        {
            this._httpClient = new HttpClient();
            this._httpClient.BaseAddress = new Uri("https://restcountries.com/v3.1/");
        }

        // Fetch all countries
        public async Task<List<Country>> GetAllCountriesAsync()
        {
            var response = await _httpClient.GetAsync("all?fields=name,flags");

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var countries = System.Text.Json.JsonSerializer.Deserialize<List<Country>>(content, new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return countries;
        }

        // Fetch a country by name
        public async Task<Country?> GetCountryByNameAsync(string name)
        {
            var response = await _httpClient.GetAsync($"name/{name}");

            if (!response.IsSuccessStatusCode)
                return null;

            var content = await response.Content.ReadAsStringAsync();
            var countries = System.Text.Json.JsonSerializer.Deserialize<List<Country>>(content, new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return countries?.FirstOrDefault();
        }
    }

    public class Country
    {
        public Name name { get; set; }
        public List<string> capital { get; set; }
        public string region { get; set; }
        public long population { get; set; }
        public Flags flags { get; set; }
    }

    public class Name
    {
        public string common { get; set; }
    }

    public class Flags
    {
        public string png { get; set; }
        public string svg { get; set; }
    }
}