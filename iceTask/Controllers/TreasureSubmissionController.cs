using iceTask.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using iceTask.Services;

namespace iceTask.Controllers
{
    public class TreasureSubmissionController : Controller
    {
        private readonly TableStorageService _tableStorageService;
        public TreasureSubmissionController(TableStorageService tableStorageService)
        {
            _tableStorageService = tableStorageService;
        }
        public async Task<IActionResult> Index()
        {
            var TreasureSubmission = await _tableStorageService.GetAllTreasureSubmissionAsync();
            return View(TreasureSubmission);
        }

    }
}


