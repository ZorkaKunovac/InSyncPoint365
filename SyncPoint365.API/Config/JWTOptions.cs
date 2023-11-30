namespace SyncPoint365.API.Config
{
    public class JWTOptions
    {
        public int Duration { get; set; }
        public string Issuer { get; set; } = default!;
        public string Audience { get; set; } = default!;
        public string Key { get; set; } = default!;
    }
}
