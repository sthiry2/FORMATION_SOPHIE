
namespace ClassLibraryCities
{
    public class CCity
    {
        private int id;
        private string nomCity;
        private string codeCountry;

        public string NomCity { get => nomCity; set => nomCity = value; }
        public string CodeCountry { get => codeCountry; set => codeCountry = value; }
        public int Id { get => id; set => id = value; }

        public CCity(string nomCity, string codeCountry)
        {
            this.nomCity = nomCity;
            this.codeCountry = codeCountry;
        }


    }
}