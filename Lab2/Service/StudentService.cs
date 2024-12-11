using Lab2.Domain;
using Lab2.Repository;

namespace Lab2.Service;

public class StudentService : Service<int, Student>
{
    public StudentService(IRepository<int, Student> repository) : base(repository)
    {
    }
}

