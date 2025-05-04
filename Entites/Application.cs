using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Application
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public int BootcampId { get; set; }
        public ApplicationState State { get; set; }

        public static implicit operator Application(Application v)
        {
            throw new NotImplementedException();
        }
    }

    public enum ApplicationState
    {
        PENDING,
        APPROVED,
        REJECTED,
        IN_REVIEW,
        CANCELLED
    }
}
