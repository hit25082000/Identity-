using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIdentity.Areas.Identity.Data;

public class AspNetCoreIdentityContext : IdentityDbContext<IdentityUser>
{
    public AspNetCoreIdentityContext(DbContextOptions<AspNetCoreIdentityContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        }
}
