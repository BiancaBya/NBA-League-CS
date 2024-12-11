using Lab2.Domain;

namespace Lab2.Repository;

public class StudentFileRepository : FileRepository<int, Student>
{
    public StudentFileRepository(string fileName) : base(fileName, EntityFileMapping.LineToStudent, EntityFileMapping.StudentToLine)
    {
    }
}
