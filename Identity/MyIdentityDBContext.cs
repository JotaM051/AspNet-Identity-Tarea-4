

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DemoDeldentity.Identity;

public class MyIdentityDBContext : IdentityDbContext<MyUser, MyRol, String>
{
    public MyIdentityDBContext(DbContextOptions<MyIdentityDBContext> options)
        : base(options)
    {
        
    }
}
