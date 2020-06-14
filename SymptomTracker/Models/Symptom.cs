using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SymptomTracker.Models
{
    public class Symptom
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        [DataType(DataType.Date)]
        public DateTime RecordDate { get; set; }

        public string OwnerId { get; set; }
        public User Owner { get; set; }
    }
}
