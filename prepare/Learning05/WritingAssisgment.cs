public class WritingAssignment : Assignment{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic){
        _title = title;
    }

    public void GetWritingInformation(){
        Console.WriteLine($"{GetSummary()}\n{_title} by {GetStudentName()}");
    }
}