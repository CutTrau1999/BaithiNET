using System;
using System.Collections.Generic;

#nullable disable

namespace BaithiNET.Models
{
    public partial class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartTime { get; set; }
        public string Date { get; set; }
        public string Duration { get; set; }
        public string Classroom { get; set; }
        public string Faculty { get; set; }
        public string Status { get; set; }
    }
}
