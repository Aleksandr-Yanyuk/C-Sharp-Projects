using StudentProgram;

using (var ctx = new SchoolContext())
{
    var stud = new Student() { StudentName = "Bill" };

    ctx.Students.Add(stud);
    ctx.SaveChanges();
}
