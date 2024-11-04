using System;
using  System.Collections.Generic;

    

namespace WebApplication1.Models{
    public static class Repository{
        private static List<Announcement> list1=new();
        static Repository(){
            list1.Add(new Announcement()  {
                ID = 1,
                Title = "Duyuru Başlığı",
                Text = "Bu bir duyuru metnidir.",
                ResponsiblePerson = "Ali Veli",
                date = DateTime.Now

            }
            );
              list1.Add(new Announcement()  {
                ID = 1,
                Title = "Duyuru Başlığı",
                Text = "Bu bir duyuru metnidir.",
                ResponsiblePerson = "Ali Veli",
                date = DateTime.Now
            }
            );
              list1.Add(new Announcement()  {
                ID = 1,
                Title = "Duyuru Başlığı",
                Text = "Bu bir duyuru metnidir.",
                ResponsiblePerson = "Ali Veli",
                date = DateTime.Now
            }
            );
              list1.Add(new Announcement()  {
                ID = 1,
                Title = "Duyuru Başlığı",
                Text = "Bu bir duyuru metnidir.",
                ResponsiblePerson = "Ali Veli",
                date = DateTime.Now
            }
            );
              list1.Add(new Announcement()  {
                ID = 1,
                Title = "Duyuru Başlığı",
                Text = "Bu bir duyuru metnidir.",
                ResponsiblePerson = "Ali Veli",
                date = DateTime.Now
            }
            );





        }
        public static List<Announcement> annlist{get{return list1;}}
        

        public static void AddAnnouncement(Announcement announcement){
            list1.Add(announcement);
        }

    }
}