namespace SERCH.Models.ApiAlma
{
    public class RespHttpClient
    {
        public bool Success { get; set; }
        public int Cod { get; set; }
        public string Desc { get; set; }
        public HttpClient HttpClientRes { get; set; }
    }
}
