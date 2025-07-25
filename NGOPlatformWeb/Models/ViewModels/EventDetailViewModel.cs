using NGOPlatformWeb.Models.Entity;
using System.Collections.Generic;

public class EventDetailViewModel
{
    public Activity Activity { get; set; }
    public string UserType { get; set; } = "Guest"; // 預設未登入
    public List<int> RegisteredActivityIds { get; set; } = new List<int>();
}
