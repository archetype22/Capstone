namespace Capstone.Models.RecipesInformation
{
    public class WinePairing
    {
        public List<string> pairedWines { get; set; }
        public string pairingText { get; set; }
        public List<ProductMatch> productMatches { get; set; }
    }


}
