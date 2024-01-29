namespace SERCH.Utilities
{
    public class WebHelpers
    {
        private static IHttpContextAccessor _httpContextAccessor;


        public static void Configure(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public static HttpContext HttpContext
        {
            get { return _httpContextAccessor.HttpContext; }
        }


    }
}
