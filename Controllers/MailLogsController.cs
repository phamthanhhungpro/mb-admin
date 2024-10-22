using mbadmin.Data;
using mbadmin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mbadmin.Controllers
{
    public class LogsController : Controller
    {
        private readonly DatabaseContext _context;
        private const int PageSize = 20;  // 20 rows per page

        public LogsController(DatabaseContext context)
        {
            _context = context;
        }

        // MailLogs
        public async Task<IActionResult> MailLogs(int page = 1)
        {
            int totalLogs = await _context.MailLog.CountAsync();
            var logs = await _context.MailLog
                                     .OrderByDescending(l => l.Time)
                                     .Skip((page - 1) * PageSize)
                                     .Take(PageSize)
                                     .ToListAsync();

            var viewModel = new LogPaginationViewModel
            {
                Logs = logs,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalLogs / (double)PageSize)
            };

            return View(viewModel);
        }

        // InfoLogs
        public async Task<IActionResult> InfoLogs(int page = 1)
        {
            int totalLogs = await _context.MailLog.CountAsync();
            var logs = await _context.MailLog
                                     .OrderByDescending(l => l.Time)
                                     .Skip((page - 1) * PageSize)
                                     .Take(PageSize)
                                     .ToListAsync();

            var viewModel = new LogPaginationViewModel
            {
                Logs = logs,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalLogs / (double)PageSize)
            };

            return View(viewModel);
        }

        // VideodlLogs
        public async Task<IActionResult> VideodlLogs(int page = 1)
        {
            int totalLogs = await _context.MailLog.CountAsync();
            var logs = await _context.MailLog
                                     .OrderByDescending(l => l.Time)
                                     .Skip((page - 1) * PageSize)
                                     .Take(PageSize)
                                     .ToListAsync();

            var viewModel = new LogPaginationViewModel
            {
                Logs = logs,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalLogs / (double)PageSize)
            };

            return View(viewModel);
        }

        // ScamCheckerLogs
        public async Task<IActionResult> ScamCheckerLogs(int page = 1)
        {
            int totalLogs = await _context.MailLog.CountAsync();
            var logs = await _context.MailLog
                                     .OrderByDescending(l => l.Time)
                                     .Skip((page - 1) * PageSize)
                                     .Take(PageSize)
                                     .ToListAsync();

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
