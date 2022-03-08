using System;
public class ReadDepartment
{
    private string departmentname;
    public ReadDepartment(string avalue)
    {
        departmentname = avalue;
    }
    public string Departmentname
    {
        get
        {
            return departmentname;
        }
    }
}
public class ReadDepartmentmain
{
    public static int Main (string[] args)
    {
        ReadDepartment d = new ReadDepartment("CS");
        Console.WriteLine("The Departmentname is: {0}", d.Departmentname);
        return 0;
    }
}