namespace SERCH.DTO
{
    public class ParametrosDataTable
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }

        public string query { get; set; }

        public string palabras { get; set; }
    }
}
