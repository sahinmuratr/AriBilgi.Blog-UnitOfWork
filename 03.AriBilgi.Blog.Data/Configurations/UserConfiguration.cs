using _025.AriBilgi.Blog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _03.AriBilgi.Blog.Data.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.UserName).IsRequired();
            builder.Property(u => u.UserName).HasMaxLength(20);


            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.Password).HasMaxLength(12);


            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.Name).HasMaxLength(20);

            builder.Property(u => u.Surname).IsRequired();
            builder.Property(u => u.Surname).HasMaxLength(20);


        }
    }
}
