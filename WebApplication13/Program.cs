using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;
using WebApplication13.Models;

var builder = WebApplication.CreateBuilder(args);
var corsOrigins = builder.Configuration.GetSection("AllowOrigins").Get<string[]>();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.Cookie.Path = "/";
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;

 
});
builder.Services.AddScoped<JwtToken>();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDataProtection();
builder.Services.AddDbContext<_2023gtafContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConn")));
builder.Services.AddSwaggerGen(options =>
{
    // 其他配置...

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
            ValidateIssuer = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidateAudience = true,
            ValidAudience = builder.Configuration["Jwt:Audience"],
            ValidateLifetime = true,
            ClockSkew = TimeSpan.Zero
        };
    });
// 加入 CORS 服務
const string OriginsFromSetting = "OriginsFromAppSettingsJson";
builder.Services.AddCors(options => {
    options.AddPolicy(
        name: OriginsFromSetting,
    builder => {
        builder
             .WithOrigins(corsOrigins)
             .AllowAnyMethod()
             .AllowAnyHeader()
             .AllowCredentials(); // 允許跨域 Cookies
    }
    );
});

// 啟用 CORS Middleware
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSession();
app.UseHttpsRedirection();

app.UseRouting(); 

app.UseCors(OriginsFromSetting); 

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
