namespace Web_Fia41_HoeffkenV_Web_QuizGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Dienste hinzufügen
            builder.Services.AddControllersWithViews();

            var app = builder.Build();


            //Konfiguration der HTTP Request Pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Aktiviert das Routing
            app.UseRouting();
            app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            app.Run();
        }
    }
}