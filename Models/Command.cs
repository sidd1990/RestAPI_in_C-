using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Models
{
    public class Command
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string platform { get; set; }
        public string Commandline { get; set; }
    }
}
