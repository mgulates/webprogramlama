using System;
using  System.Collections.Generic;

    

namespace WebApplication1.Models{
    public static class Repository{
        private static List<Announcement> list1=new();
        static Repository(){
            list1.Add(new Announcement(){
                ID=1,
                date=DateTime.Now,

                Title="Artificial Intelligence Academic Thesis Program Begins", 
                Text="The program aims to increase competencies in the field of artificial intelligence in the defense industry, contribute to the need for qualified human resources in the sector and establish cooperation between academia and industry in the field of artificial intelligence. Students accepted to the program will be announced on October 31. Successful students will benefit from opportunities such as internship, candidate engineering program and project support in line with their competencies.", 
                ResponsiblePerson="Alican"
            });
            list1.Add(new Announcement(){
                ID=2,
                date=DateTime.Now, 
                Title="2209-A - University Students Research Projects Support Program Call", 
                Text="2209-A University Students Research Projects Support Program 2024 1st semester call is open for application. Applications can be made via TUBITAK Management Information System (tybs.tubitak.gov.tr) until 17.30 on November 01, 2024.", 
                ResponsiblePerson="Nurcan"
            });
            list1.Add(new Announcement(){
                ID=3,
                date=DateTime.Now, 
                Title="4001 National and International Competition/Event Participation Support 2nd Call", 
                Text="The 2nd call for 4001 National and International Competition/Event Participation Support, whose first call period was held between August 2 and September 30, was published on October 1, 2024 and opened for application.", 
                ResponsiblePerson="Gülcan"
            });
                list1.Add(new Announcement(){
                ID=3,
                date=DateTime.Now, 
                Title="Adaptation to University Life Program", 
                Text="An orientation program has been organized for our new students to get to know university life and Sakarya University more closely; the topics, programs, people and places to be informed are attached.", 
                ResponsiblePerson="Mehmetcan"
            }
            );





        }
        public static List<Announcement> annlist{get{return list1;}}
        

        public static void AddAnnouncement(Announcement announcement){
          announcement.ID=list1.Count+1;
          announcement.date=DateTime.Now;
            list1.Add(announcement);

        }


        public static Announcement GetElement(int id){
          return list1.FirstOrDefault(Ann=>Ann.ID == id); 
        }

    }
}