namespace SERCH.Models.ApiAlma
{
    public class ResGetTokenAlma
    {
        public bool Success { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public ResTokenAlma Result { get; set; }
    }


    public class ResTokenAlma
    {
        public string Token { get; set; }
        public DateTime Expired { get; set; }
        public string Mensaje { get; set; }
    }
}
