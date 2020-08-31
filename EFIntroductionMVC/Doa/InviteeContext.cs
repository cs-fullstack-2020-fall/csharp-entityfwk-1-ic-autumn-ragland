using EFIntroductionMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EFIntroductionMVC.Doa
{
    // database context
    public class InviteeContext : DbContext
    {
        // constructor extends base constructor from DbContext
        public InviteeContext(DbContextOptions<InviteeContext> options) : base(options)
        {
        }
        // database set : House Party Invitee objects
        public DbSet<HousePartyInvitee> invitees {get;set;}
    }
}