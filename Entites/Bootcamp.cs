using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Bootcamp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InstructorId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public BootcampState State { get; set; }
    }

    public enum BootcampState
    {
        PREPARING,
        OPEN_FOR_APPLICATION,
        IN_PROGRESS,
        FINISHED,
        CANCELLED
    }
}
