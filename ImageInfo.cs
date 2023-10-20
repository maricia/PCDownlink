using System.Text.Json;




namespace PCDownlink
{
    public class Rootobject
    {
        public Source[] sources { get; set; }
    }

    public class Source
    {
        public string name { get; set; }
        public string spacecraft { get; set; }
        public int interval { get; set; }
        public float aspect { get; set; }
        public Url url { get; set; }
    }

    public class Url
    {
        public string tiny { get; set; }
        public string small { get; set; }
        public string large { get; set; }
        public string full { get; set; }
    }


    


}
