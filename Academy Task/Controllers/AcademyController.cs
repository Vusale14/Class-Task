using Academy_Task.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Academy_Task.Controllers
{
    public class AcademyController:Controller
    {
        private readonly AttendanceDbContext _context;
        public AcademyController(AttendanceDbContext context)
        {
            _context = context;
        }
        public IActionResult Index() 
        {
            var AttendanceInfo = _context.GroupTeacherInformations
                                                                 .Include(gti  => gti.Group)
                                                                 .Include(gti  => gti.Teacher)
                                                                 .Include(gti => gti.Information)
                                                                 .ToList();
            return View(AttendanceInfo);
        }
    }
}
