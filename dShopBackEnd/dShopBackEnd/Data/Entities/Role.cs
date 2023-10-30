using Microsoft.AspNetCore.Identity;

namespace dShopBackEnd.Data.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public string? Description { get; set; }
    }
}
