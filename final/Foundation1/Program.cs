using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        //--------- FIRST VIDEO ---------//
        Video link = new Video();
        link._title = "https://www.youtube.com/watch?v=xbLeIIyh-Bc";
        link._author = "Akpan and Oduma";
        link._length = 20;

        Comment comment1 = new Comment();
        comment1._name = "John";
        comment1._text = "Nice video";
        Comment comment2 = new Comment();
        comment2._name = "Doe";
        comment2._text = "No action";
        Comment comment3 = new Comment();
        comment3._name = "Alien";
        comment3._text = "Low box office rating";

        link._comments.Add(comment1);
        link._comments.Add(comment2);
        link._comments.Add(comment3);


        //--------- SECOND VIDEO ---------//
        Video link1 = new Video();
        link1._title = "https://www.youtube.com/watch?v=Y3-a14Uq0kE";
        link1._author = "Oduma Regime";
        link1._length = 35;

        Comment comment4 = new Comment();
        comment4._name = "Rhio King";
        comment4._text = "Killed my expectations";
        Comment comment5 = new Comment();
        comment5._name = "Vamos";
        comment5._text = "This is very terrific";
        Comment comment6 = new Comment();
        comment6._name = "Anderson";
        comment6._text = "Must watch for all";

        link1._comments.Add(comment4);
        link1._comments.Add(comment5);
        link1._comments.Add(comment6);


        //--------- THIRD VIDEO ---------//
        Video link2 = new Video();
        link2._title = "https://www.youtube.com/watch?v=VhVESFwl8Cs";
        link2._author = "Mark Angel";
        link2._length = 65;

        Comment comment7 = new Comment();
        comment7._name = "Zoba";
        comment7._text = "Could have done better";
        Comment comment8 = new Comment();
        comment8._name = "Azzra";
        comment8._text = "Total waste of data";
        Comment comment9 = new Comment();
        comment9._name = "Jane";
        comment9._text = "Action and suspense filled";

        link2._comments.Add(comment7);
        link2._comments.Add(comment8);
        link2._comments.Add(comment9);


        //--------- FOURTH VIDEO ---------//
        Video link3 = new Video();
        link3._title = "https://www.youtube.com/watch?v=ulPjELLQk9k";
        link3._author = "Silver Derume";
        link3._length = 80;

        Comment comment10 = new Comment();
        comment10._name = "Boots";
        comment10._text = "First to watch and download";
        Comment comment11 = new Comment();
        comment11._name = "Neil Johnson";
        comment11._text = "First 60 minutes was a kill";
        Comment comment12 = new Comment();
        comment12._name = "Flakers Jaders";
        comment12._text = "I love everything about this damn movie";

        link3._comments.Add(comment10);
        link3._comments.Add(comment11);
        link3._comments.Add(comment12);

        videoList.Add(link);
        videoList.Add(link1);
        videoList.Add(link2);
        videoList.Add(link3);

        Console.WriteLine();
        foreach (Video video in videoList)
        {
            video.DisplayVideo();
            Console.Write($"Total Comments: {video.TotalComments()}\n");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}