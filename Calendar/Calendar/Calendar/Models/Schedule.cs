using System;
using System.Collections.Generic;
using System.Text;


namespace Calendar.Models
{
    public class Schedule
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Hour { get; set; }
        public List<Features> Features { get; set; }
    }
}
