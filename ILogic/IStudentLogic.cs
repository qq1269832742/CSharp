using System.Collections.Generic;
using Repository.Models;

namespace ILogic
{
    public interface IStudentLogic
    {
        string GetName(int id);

        List<Student> GetList();
    }
}
