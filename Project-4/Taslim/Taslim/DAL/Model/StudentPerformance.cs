using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taslim.DAL.Model
{
    class StudentPerformance
    {
        public string Department { get; set; }
        public string Semester { get; set; }
        public string Batch { get; set; }
        public string StudentId { get; set; }
        public decimal Exam { get; set; }
        public decimal ExtraCurriculum { get; set; }
        public decimal TotalPerformanceValue { get; set; }

    }
}
