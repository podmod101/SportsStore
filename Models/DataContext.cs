using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models {

    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> opts)
            : base(opts) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Rating> Ratings { get; set; }


        public DbSet<CoachDetail> CoachDetail { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<County> County { get; set; }
        public DbSet<Division> Division { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Level> Level { get; set; }
        public DbSet<SchoolDetail> SchoolDetail { get; set; }
        public DbSet<SchoolTournamentDetail> SchoolTournamentDetail { get; set; }
        public DbSet<Sector> Sector { get; set; }
        public DbSet<ShootDay> ShootDay { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentDetail> StudentDetail { get; set; }
        public DbSet<StudentTournamentDetail> StudentTournamentDetail { get; set; }
        public DbSet<Tournament> Tournament { get; set; }
    }
}