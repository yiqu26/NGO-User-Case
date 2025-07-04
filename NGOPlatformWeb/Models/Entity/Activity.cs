﻿using System;
using System.ComponentModel.DataAnnotations;
namespace NGOPlatformWeb.Models.Entity

{
    public class Activity
    {
        public int ActivityId { get; set; }

        [Required]
        public string? ActivityName { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public string? Location { get; set; }

        public int MaxParticipants { get; set; }

        public int CurrentParticipants { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int WorkerId { get; set; }

        public string? TargetAudience { get; set; }

        public string? Status { get; set; }
    }
}
