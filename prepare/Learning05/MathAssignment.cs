public class MathAssignment : Assignment{
    private string _section;
    private string _problem;

    public MathAssignment(string name, string topic, string section, string problem) : base(name, topic){
        _section = section;
        _problem = problem;
    }

    public void GetHomeWorkList(){
        Console.WriteLine($"{GetSummary()}\nSection: {_section} Problem: {_problem}");
    }
}