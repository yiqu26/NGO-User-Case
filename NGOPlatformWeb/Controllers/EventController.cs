using NGOPlatformWeb.Models; // 引用你的 Models 命名空間
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using NGOPlatformWeb.Models.Entity;

public class EventController : Controller
{
    private readonly NGODbContext _dbContext;

    public EventController(NGODbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index(int? id)
    {
        if (id == null)
        {
            return RedirectToAction("Index", "Event");
        }

        var activity = _dbContext.Activities.FirstOrDefault(a => a.ActivityId == id);
        if (activity == null)
        {
            return NotFound();
        }

        return View(activity); // <--- 傳遞活動物件進 View
    }
}
