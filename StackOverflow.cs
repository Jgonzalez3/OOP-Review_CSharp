using System;
using System.Collections.Generic;

namespace OOP{
    public class Post{
        private readonly string title;
        private readonly string description;
        private int votes;
        private readonly DateTime created_at;
        public Post(string title, string description){
            this.title = title;
            this.description = description;
            created_at = DateTime.Now;
        }
        public void VoteUp(){
            this.votes += 1;
        }
        public void VoteDown(){
            this.votes -= 1;
        }
        public void DisplayVotes(){
            System.Console.WriteLine($"Total Votes: {this.votes}, created on {created_at}");
        }
        //

    }
}