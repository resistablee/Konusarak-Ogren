
namespace KonusarakOgren.Entity.Contract
{
    public class AccessTokenContract
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public int? ExpiresIn { get; set; }
        public DateTime RefreshTokenExpireDate { get; set; }
    }
}
