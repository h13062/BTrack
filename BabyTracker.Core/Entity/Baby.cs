using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyTracker.Core.Entity
{
    public class Baby
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Weight { get; set; }
        public DateTime SleepStart { get; set; }
        public DateTime SleepEnd { get; set; }
        public DateTime PlayStart { get; set; }
        public DateTime PlayEnd { get; set; }
        public DateTime EatStart { get; set; }
        public DateTime EatEnd { get; set; }
    }
}
