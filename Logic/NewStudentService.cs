using System;
using System.Collections.Generic;
using ILogic;
using IRepository;
using Repository.Models;

namespace Logic
{
    public class StudentLogic : IStudentLogic
    {
        private readonly IStudentRepository _studentRepository;
        public StudentLogic(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        //public string SayHello(string name)
        //{
        //    return "Hello " + name;
        //}
     

        public string GetName(int id)
        {
            return _studentRepository.GetName(id);
        }

        public List<Student> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
