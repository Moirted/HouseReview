using HouseReview.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseReview.Areas.Identity.Data
{
    public class CommentsDBContext:DbContext
    {
        public CommentsDBContext(DbContextOptions<CommentsDBContext> options):base(options)
        {

        }
        public DbSet<Comment> Comments { get; set; }
    }
}
