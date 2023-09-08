services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
