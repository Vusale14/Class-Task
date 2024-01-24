using Academy_Task.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using Group = System.Text.RegularExpressions.Group;
using Information = Microsoft.VisualBasic.Information;

namespace Academy_Task.DAL
{
    public class AttendanceDbContext:DbContext
    {
        public AttendanceDbContext(DbContextOptions<AttendanceDbContext> options) : base(options)
        {

        }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Information> Informations{ get; set; }
        public DbSet<GroupTeacher> GroupTeachers { get; set; }
        public DbSet<GroupTeacherInformation> GroupTeacherInformations { get; set; }

    }
}
