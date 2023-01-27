namespace Capstone.Models.RecipesInformation
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AnalyzedInstruction
    {
        public string name { get; set; }
        public List<Step> steps { get; set; }
    }


}
