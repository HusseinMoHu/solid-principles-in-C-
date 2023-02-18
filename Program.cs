using System;
using System.Collections.Generic;
using System.Linq;


// Change the namespace based on concept you are trying to demonstrate (SRP, OCP, LSP, ISP, DIP)
namespace SolidDemo.LSP
{
  public class Program
  {
    public static void Main(string[] args)
    {

      PostDatabase db = new PostDatabase();
      List<string> newPosts = new List<string>();
      newPosts.Add("original post");
      newPosts.Add("#tag post");
      newPosts.Add("@mention post");

      Post postObj;
      foreach (var post in newPosts)
      {
        if (post.StartsWith("#"))
        {
          postObj = new TagPost();
        }
        else if (post.StartsWith("@"))
        {
          postObj = new MentionPost();
        }
        else
        {
          postObj = new Post();
        }

        string result = postObj.CreatePost(db, post);
        Console.WriteLine(result);
      }

    }
  }
}