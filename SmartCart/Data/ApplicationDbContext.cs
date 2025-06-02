using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartCart.Models;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    private readonly IPasswordHasher<ApplicationUser> _passwordHasher;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IPasswordHasher<ApplicationUser> passwordHasher)
         : base(options)
    {
        _passwordHasher = passwordHasher;
    }




    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Category> Categories { get; set; }

    public DbSet<ContactMessage> ContactMessages { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Payment> Payments { get; set; } // إضافة DbSet ل Payment

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var adminRoleId = Guid.NewGuid().ToString();
        var userRoleId = Guid.NewGuid().ToString();
        var adminUserId = Guid.NewGuid().ToString();

        modelBuilder.Entity<IdentityRole>().HasData(
        new IdentityRole()
        {
            Id = adminRoleId,
            Name = "Admin",
            NormalizedName = "admin",
            ConcurrencyStamp = Guid.NewGuid().ToString()
        },
         new IdentityRole()
         {
             Id = userRoleId,
             Name = "User",
             NormalizedName = "user",
             ConcurrencyStamp = Guid.NewGuid().ToString()
         }


    );
        // إنشاء مستخدم الأدمن
        var adminUser = new ApplicationUser
        {
            Id = adminUserId,
            UserName = "admin@example.com",
            NormalizedUserName = "ADMIN@EXAMPLE.COM",
            Email = "admin@example.com",
            NormalizedEmail = "ADMIN@EXAMPLE.COM",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
            // يمكن إضافة خصائص إضافية هنا
        };

        // تشفير كلمة المرور
        adminUser.PasswordHash = _passwordHasher.HashPassword(adminUser, "Admin@123");

        modelBuilder.Entity<ApplicationUser>().HasData(adminUser);

        // تعيين دور الأدمن للمستخدم
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = adminUserId
            }
        );

        // العلاقات بين الكيانات
        modelBuilder.Entity<ApplicationUser>()
            .HasMany(u => u.Carts)  // كل مستخدم يمكن أن يمتلك عدة سلات
            .WithOne(c => c.User)
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.Cascade);



        modelBuilder.Entity<Product>()
        .Property(p => p.CategoryId)
        .IsRequired(true); // تعديل العمود ليقبل NULL




        modelBuilder.Entity<CartItem>()
            .HasOne(ci => ci.Cart)
            .WithMany(c => c.CartItems)
            .HasForeignKey(ci => ci.CartId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CartItem>()
            .HasOne(ci => ci.Product)
            .WithMany(p => p.CartItems)
            .HasForeignKey(ci => ci.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Category>()
            .HasMany(c => c.Products)
            .WithOne(p => p.Category)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ApplicationUser>()
            .HasMany(u => u.Orders)
            .WithOne(o => o.User)
            .HasForeignKey(o => o.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<OrderItem>()
            .HasOne(oi => oi.Order)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(oi => oi.OrderId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<OrderItem>()
            .HasOne(oi => oi.Product)
            .WithMany(p => p.OrderItems)
            .HasForeignKey(oi => oi.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        // تحديد القيود الخاصة بالأعمدة
        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18,2)")
            .HasDefaultValue(0);

        modelBuilder.Entity<CartItem>()
            .Property(ci => ci.Quantity)
            .HasColumnType("int")
            .HasDefaultValue(1);

        modelBuilder.Entity<Order>()
            .Property(o => o.TotalAmount)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<OrderItem>()
            .Property(oi => oi.Price)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<ContactMessage>()
            .Property(cm => cm.SentDate)
            .HasDefaultValueSql("GETDATE()");

        modelBuilder.Entity<Category>()
            .Property(c => c.Name)
            .HasMaxLength(100);

        modelBuilder.Entity<Product>()
            .Property(p => p.Name)
            .HasMaxLength(200);

        modelBuilder.Entity<ContactMessage>()
            .Property(cm => cm.Name)
            .HasMaxLength(100);

        modelBuilder.Entity<ContactMessage>()
            .Property(cm => cm.Message)
            .HasMaxLength(1000);

        modelBuilder.Entity<ApplicationUser>()
            .Property(u => u.UserName)
            .HasMaxLength(150);

        modelBuilder.Entity<Order>()
            .Property(o => o.OrderDate)
            .HasDefaultValueSql("GETDATE()");

        // تحديد العلاقة بين Order و Payment (One-to-One أو One-to-Many)
        modelBuilder.Entity<Payment>()
            .HasOne(p => p.Order)  // كل عملية دفع مرتبطة بطلب واحد
            .WithOne(o => o.Payment)  // وطلب واحد يمكن أن يكون له عملية دفع واحدة فقط
            .HasForeignKey<Payment>(p => p.OrderId)
            .OnDelete(DeleteBehavior.Cascade);  // عند حذف الطلب يتم حذف الدفع المرتبط به

        // تحديد القيود الخاصة بـ Payment
        modelBuilder.Entity<Payment>()
            .Property(p => p.Amount)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Payment>()
            .Property(p => p.Date)
            .HasDefaultValueSql("GETDATE()");

        modelBuilder.Entity<Payment>()
            .Property(p => p.Method)
            .HasMaxLength(50);

        // تحديد القيود الخاصة بـ ContactMessage
        modelBuilder.Entity<ContactMessage>()
            .Property(cm => cm.Email)
            .HasMaxLength(100);

        modelBuilder.Entity<ContactMessage>()
            .Property(cm => cm.Name)
            .HasMaxLength(150);




        // إضافة بيانات للمستخدمين
        modelBuilder.Entity<ApplicationUser>().HasData(
           new ApplicationUser
           {
               Id = "1",
               Email = "user1@example.com",
               // إضافة كلمة مرور مشفرة
               PasswordHash = _passwordHasher.HashPassword(null, "Password123!")
           },
                new ApplicationUser
                {
                    Id = "2",
                    Email = "user2@example.com",
                    // إضافة كلمة مرور مشفرة
                    PasswordHash = _passwordHasher.HashPassword(null, "Password123!")
                }
        );




        // إضافة بيانات للفئات
        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Casual"
            },
            new Category
            {
                Id = 2,
                Name = "Classic"
            }
        );

        modelBuilder.Entity<Product>().HasData(
             new Product
             {
                 Id = 1,
                 Name = "Man-Shirt",
                 Description = "Men's casual shirt",
                 Price = 500.00m,
                 CategoryId = 1,
                 ImagePath = "/img/51.jpg"
             },
             new Product
             {
                 Id = 2,
                 Name = "Summer-Vibes",
                 Description = "Be Cool",
                 Price = 300.00m,
                 CategoryId = 1,
                 ImagePath = "/img/30.jpg"
             },
             new Product
             {
                 Id = 3,
                 Name = "jeans-shirt",
                 Description = "Comfortable jeans shirt",
                 Price = 450.00m,
                 CategoryId = 1,
                 ImagePath = "/img/11.jpg"
             },
             new Product
             {
                 Id = 4,
                 Name = "Suger-Dady-Suit",
                 Description = "Oh Suger Dady",
                 Price = 5000.00m,
                 CategoryId = 2,
                 ImagePath = "/img/shop_05.jpg"
             },
             new Product
             {
                 Id = 5,
                 Name = "Black-Suit",
                 Description = "Black Always win",
                 Price = 2500.00m,
                 CategoryId = 2,
                 ImagePath = "/img/36.jpg"
             },
             new Product
             {
                 Id = 6,
                 Name = "Blue-Jacket",
                 Description = "very Elegent",
                 Price = 1000.00m,
                 CategoryId = 2,
                 ImagePath = "/img/shop_07.jpg"
             },
              new Product
              {
                  Id = 7,
                  Name = "Green-shirt",
                  Description = "Magic",
                  Price = 200.00m,
                  CategoryId = 1,
                  ImagePath = "/img/53.jpg"
              },
               new Product
               {
                   Id = 8,
                   Name = "Gray-Suit",
                   Description = "Thats Amazing",
                   Price = 4000.00m,
                   CategoryId = 2,
                   ImagePath = "/img/61.jpg"
               },
                 new Product
                 {
                     Id = 9,
                     Name = "Flowered-shirt",
                     Description = "Youth-Flower",
                     Price = 400.00m,
                     CategoryId = 1,
                     ImagePath = "/img/56.jpg"
                 }

 );



        // إضافة بيانات للسلال
        modelBuilder.Entity<Cart>().HasData(
            new Cart
            {
                Id = 1,
                UserId = "1" // ربط السلة بالمستخدم الأول
            },
            new Cart
            {
                Id = 2,
                UserId = "2" // ربط السلة بالمستخدم الثاني
            }
        );

        // إضافة بيانات لعناصر السلة
        modelBuilder.Entity<CartItem>().HasData(
            new CartItem
            {
                Id = 1,
                CartId = 1,
                ProductId = 1,
                Quantity = 2
            },
            new CartItem
            {
                Id = 2,
                CartId = 2,
                ProductId = 2,
                Quantity = 1
            }
        );

     

        // إضافة بيانات لعنصر الطلبات
        modelBuilder.Entity<OrderItem>().HasData(
            new OrderItem
            {
                Id = 1,
                OrderId = 1,
                ProductId = 1,
                Quantity = 2,
                Price = 500.00m
            },
            new OrderItem
            {
                Id = 2,
                OrderId = 2,
                ProductId = 2,
                Quantity = 1,
                Price = 100.00m
            }
        );

        // إضافة بيانات للدفع
        modelBuilder.Entity<Payment>().HasData(
            new Payment
            {
                Id = 1,
                OrderId = 1,
                Method = "Credit Card",
                Status = "Paid",
                Amount = 1000.00m,
                Date = DateTime.Now
            },
            new Payment
            {
                Id = 2,
                OrderId = 2,
                Method = "Paypal",
                Status = "Paid",
                Amount = 200.00m,
                Date = DateTime.Now
            }
        );

        // إضافة بيانات للرسائل التواصل
        modelBuilder.Entity<ContactMessage>().HasData(
            new ContactMessage
            {
                Id = 1,
                Name = "John Doe",
                Email = "johndoe@example.com",
                Message = "I need help with my order.",
                SentDate = DateTime.Now
            },
            new ContactMessage
            {
                Id = 2,
                Name = "Jane Smith",
                Email = "janesmith@example.com",
                Message = "Can you provide more details about the products?",
                SentDate = DateTime.Now
            }
        );


        modelBuilder.Entity<Order>().HasData(
      new Order
      {
          Id = 1,
          UserId = "user-123",  // نفس Id المستخدم في AspNetUsers
          Address = "123 Test St, Cairo",
          Phone = "01000000000",
          TotalAmount = 100.00m,
          OrderDate = new DateTime(2024, 01, 01),
          Status = "Pending"
      }
  );



    }
}
