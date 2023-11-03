using E_Commerce_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using User.Management.Service.Data_Access_Layer__DAL_.Models;



namespace User.Management.Service.Data_Access_Layer__DAL_.Context
{
    public class Context : IdentityDbContext<UserModel>
    {

        public Context(DbContextOptions DbOptions ) : base(DbOptions)
        {
            PasswordHasher = new PasswordHasher<UserModel>();
        }



        #region Models 

        public DbSet<UserModel> Users => Set<UserModel>();
        public DbSet<ProductModel> Products => Set<ProductModel>();

        public PasswordHasher<UserModel> PasswordHasher { get; init; }




        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {


            // Define unique constraint for the Email property
            builder.Entity<UserModel>()
                .HasIndex(u => u.Email)
                .IsUnique();


            var SystemUsers = new List<UserModel>()
            {
                new UserModel()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "MohandAyman",
                    Email = "Mohandayman0127@gmail.com",
                },
                new UserModel()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "OsamaHassan",
                    Email = "OsamaHassan@gmail.com",
                },
            };
            SystemUsers[0].PasswordHash = PasswordHasher.HashPassword(SystemUsers[0], "Mohand0127");
            SystemUsers[1].PasswordHash = PasswordHasher.HashPassword(SystemUsers[1], "Mohand0127");
            builder.Entity<UserModel>().HasData(SystemUsers);


            var SystemCategories = new List<CategoryModel>()
            {
                new CategoryModel()
                {
                    Id = 1,
                    Name = "Technology",
                    
                },   new CategoryModel()
                {
                    Id = 2,
                    Name = "Fashion",
                    
                },
             
            };

            builder.Entity<CategoryModel>().HasData(SystemCategories);


            var SystemProducts = new List<ProductModel>()
            {
                new ProductModel()
                {
                    ProductCode = Guid.NewGuid().ToString(),
                    Name = "pants",
                    ImgUrl = "assets/Images/PantsImg.webp",
                    price = 100,
                    Discount_Rate = 0.1M,
                    CategoryId = 2,
                    Minimum_Quantity = 500,
                },
                new ProductModel()
                {
                    ProductCode = Guid.NewGuid().ToString(),
                    Name = "mobile",
                    ImgUrl = "assets/Images/MobileImg.jpeg",
                    price = 4000,
                    Discount_Rate = 0.2M,
                    CategoryId = 1,
                    Minimum_Quantity = 1000,
                },
              

               
            };

            builder.Entity<ProductModel>().HasData(SystemProducts);

            base.OnModelCreating(builder);
        }
    }
    }
