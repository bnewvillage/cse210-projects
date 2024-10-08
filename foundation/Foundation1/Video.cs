using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;

public class Video{
    public string _title;
    public string _author;
    public int _length;
    public List<Comments> _comments = new List<Comments>();

    public Video(string title, string author, int length){
        _title = title;
        _author = author;   
        _length = length;
    }

    public string GetTime(int length){
        int minutes = length / 60;
        int seconds = length % 60;
        string time = $"{minutes}:{seconds:D2}";
        return time;
    }

    public void SetComments(Comments comment){
        _comments.Add(comment);
    }

    public void GetComments(){
        foreach(Comments comment in _comments){
            Console.WriteLine($"Name: {comment._commenterName}\nComment: {comment._commentText}\n");
        }
    }

    public int GetCommentsTotal(){
        int totalComments = _comments.Count;
        return totalComments;
    }

    public void Display(){
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {GetTime(_length)}\nNumber of Comments: {GetCommentsTotal()}\n");
        GetComments();
    }

}

