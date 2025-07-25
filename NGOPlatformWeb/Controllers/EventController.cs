using NGOPlatformWeb.Models; // 引用你的 Models 命名空間
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using NGOPlatformWeb.Models.Entity;
using System.Security.Claims;

public class EventController : Controller
{
    private readonly NGODbContext _dbContext;

    public EventController(NGODbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index(int? id)
    {
        if (id == null) return RedirectToAction("Index", "Event");

        var activity = _dbContext.Activities.FirstOrDefault(a => a.ActivityId == id);
        if (activity == null) return NotFound();

        // ⭐ 模擬個案登入使用者 ID（正式上線請從 Claims 抓）
        int userId = 5;
        string userType = "Case"; // "Case" or "User"...

        // 查出已報名的活動 ID 清單
        var registeredIds = _dbContext.CaseActivityRegistrations
            .Where(r => r.CaseId == userId)
            .Select(r => r.ActivityId)
            .ToList();

        ViewBag.UserType = userType;
        ViewBag.RegisteredActivityIds = registeredIds;

        return View(activity);
    }
}
