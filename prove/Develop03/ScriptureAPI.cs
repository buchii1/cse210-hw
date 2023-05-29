using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

// A code template for the category of things known as ScriptureAPI.
// The responsibility of a ScriptureAPI is to fetch the details of a scripture
//      from an external API.   
public class ScriptureAPI
{
    private string _reference;
    private Dictionary<string, string> _scripture = new Dictionary<string, string>();

    // A constructor that accepts a _reference argument
    public ScriptureAPI(string reference)
    {
        _reference = reference;
    }

    // A method that makes an API call to an endpoint using the reference provided
    //  and appends the result to a dictionary.
    public async Task QueryAPI()
    {
        // Create an instance of HttpClient();
        HttpClient client = new HttpClient();

        try
        {
            // Querystring
            string url = $"https://bible-api.com/{_reference}?translation=kjv";

            // Send a GET request to the API endpoint
            HttpResponseMessage response = await client.GetAsync(url);

            // Check the response status code
            if (response.IsSuccessStatusCode)
            {
                // Read the response content as a string
                string data = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON response into a dynamic object
                dynamic responseObj = Newtonsoft.Json.JsonConvert.DeserializeObject(data);

                // Get the values of the text
                string reference = responseObj.reference;
                string text = responseObj.text;

                // Remove new line characters
                string formattedText = text.Replace("\n", " ");

                // Store the reference and text to the dictionary
                _scripture.Add(reference, formattedText);
            }
            else
            {
                Console.WriteLine($"Request failed with status code: {response.StatusCode}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An exception occurred: {ex.Message}");
        }
        finally
        {
            // Dispose the HttpClient instance
            client.Dispose();
        }
    }

    // A getter method to return the content of the dictionary
    public KeyValuePair<string, string> GetScripture()
    {
        KeyValuePair<string, string> selected = _scripture.FirstOrDefault();
        return selected;
    }
}