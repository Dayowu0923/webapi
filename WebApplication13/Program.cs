using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;
using WebApplication13.Models;
using WebApplication13.Profiles;
using WebApplication13.Services;


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
builder.Services.AddScoped<IJwtToken, JwtToken>();
builder.Services.AddScoped<IAuthenticationService,LoginService>();
builder.Services.AddScoped<ICog1Service,Cog1Service>();
builder.Services.AddScoped<ICogItemService, CogItemService>();
builder.Services.AddScoped<ICaptchaService,CaptchaService>();


builder.Services.AddHttpContextAccessor();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDataProtection();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


builder.Services.AddDbContext<_2023gtafContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConn")));
builder.Services.AddSwaggerGen(options =>
{
    // ¨ä¥L°t¸m...

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
const string OriginsFromSetting = "OriginsFromAppSettingsJson";
builder.Services.AddCors(options => {
    options.AddPolicy(
        name: OriginsFromSetting,
    builder => {
        builder
             .WithOrigins(corsOrigins)
             .AllowAnyMethod()
             .AllowAnyHeader()
             .AllowCredentials();
    }
    );
});
var app = builder.Build();

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
