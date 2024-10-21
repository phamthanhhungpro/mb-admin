using mbadmin.Data;
using mbadmin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mbadmin.Controllers
{
    public class MailLogsController : Controller
    {
        private readonly DatabaseContext _context;
        private const int PageSize = 20;  // 20 rows per page

        public MailLogsController(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            // Get the total number of logs
            int totalLogs = await _context.MailLog.CountAsync();

            // Calculate the logs to skip for pagination
            var logs = await _context.MailLog
                                     .OrderByDescending(l => l.Time)
                                     .Skip((page - 1) * PageSize)
                                     .Take(PageSize)
                                     .ToListAsync();

            // Pass the logs and pagination info to the view
            var viewModel = new LogPaginationViewModel
            {
                Logs = logs,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalLogs / (double)PageSize)
            };

            return View(viewModel);
        }
    }
}
