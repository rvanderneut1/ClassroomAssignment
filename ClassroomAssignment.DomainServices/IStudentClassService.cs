using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.DomainServices
{
    public interface IStudentClassService
    {

        public int GetStudentCount(Guid classId);
    }
}
