using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    // Banco de Dados em Memória
    public class BlogDataContext : DbContext
    {
        // As tabelas do Banco de Dados
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=Ra170115!");
    }
}