using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Design;

namespace ActivityCenter.Models
{
    public class User
    {
        public int UserId {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
        public List<Activ> CreatedActivities {get; set;}
        public List<Participate> ParticipatingActivities {get; set;}
        public User()
        {
            CreatedActivities = new List<Activ>();
        }

    }
    public class Activ
    {
        public int ActivId {get; set;}
        public string Title {get; set;}
        public DateTime Date {get; set;}
        public string Time {get; set;}
        public int Duration {get; set;}
        public string Description {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
        public User Coordinator {get; set;}
        public int UserId {get; set;}
        public List<Participate> Participants {get; set;}
    }
    public class Participate 
    {
        public int ParticipateId {get; set;}
        public int ActivId {get; set;}
        public Activ ParticipatingActivities {get; set;}
        public int UserId {get; set;}
        public User ParticipatingUsers {get; set;}
    }
}