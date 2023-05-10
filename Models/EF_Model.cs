using Microsoft.EntityFrameworkCore;

namespace Web_Fia41_HoeffkenV_Web_QuizGame.Models
{
    public class EF_Model : DbContext
    {
        public DbSet<Question> Questions{ get; set; }

        public DbSet<NNQF> NNQFs { get; set; }

        public DbSet<Fraktion> Fraktions { get; set; }

        public DbSet<HighScore> HighScores { get; set; }

        public string DbPath { get; }

        public EF_Model()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "QuizGame.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

    
}
