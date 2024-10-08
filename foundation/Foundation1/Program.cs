using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Eat", "Professional Foodie", 300);
        Comments comment1 = new Comments("John", "I didn't really learn anything.");
        Comments comment2 = new Comments("Jane", "This was very helpful, thanks!");
        Comments comment3 = new Comments("Sam", "I love the part about dessert!");
        video1.SetComments(comment1);
        video1.SetComments(comment2);
        video1.SetComments(comment3);

        Video video2 = new Video("Cats Doing Funny Things", "Cat Lover", 180);
        Comments comment4 = new Comments("Alice", "So funny!");
        Comments comment5 = new Comments("Bob", "I love cats!");
        Comments comment6 = new Comments("Charlie", "I needed this!");
        video2.SetComments(comment4);
        video2.SetComments(comment5);
        video2.SetComments(comment6);
        
        Video video3 = new Video("How to Tie a Shoe", "Helpful Person", 120);
        Comments comment7 = new Comments("Diana", "Thanks for the tip!");
        Comments comment8 = new Comments("Ethan", "This is great information!");
        Comments comment9 = new Comments("Fiona", "I learned something new today!");
        video3.SetComments(comment7);
        video3.SetComments(comment8);
        video3.SetComments(comment9);

        video1.Display();
        video2.Display();
        video3.Display();
    }
}