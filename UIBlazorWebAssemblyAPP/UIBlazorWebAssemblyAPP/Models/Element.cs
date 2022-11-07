using System.Text.Json.Serialization;

namespace UIBlazorWebAssemblyAPP.Models
{
    public class Element { 
    //{
    //    public string Account { get; set; }
    //    public int Printavo { get; set; }        
    //    public int Requests { get; set; }
    //    public int Mockups { get; set; }
    //    public int Phone { get; set; }
    //    public string Date { get; set; }
    //    //public string Graphic { get; set; }
    //    public string Graphic { get; set; } = string.Empty;
    //    public string Email { get; set; }
    //    public int Number { get; set; }

    //    [JsonPropertyName("small")]
    //    public string Website { get; set; }

    //    public string Tags { get; set; }
    //    public double Molar { get; set; }
    //    public string Contact { get; set; }


        public string Group { get; set; }
        public int Position { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        [JsonPropertyName("small")]
        public string Sign { get; set; }
        public double Molar { get; set; }
        public IList<int> Electrons { get; set; }

        public override string ToString()
        {
            return $"{Sign} - {Name}";
        }

    }
}
