using System;
using  System.Collections.Generic;

    

namespace WebApplication1.Models{
    public static class Repository{
        private List<Announcement> list1=new();
        static Repository(){
            list1.Add(new Announcement()  {
                ID = 1,
                Title = "Duyuru Başlığı",
                Text = "Bu bir duyuru metnidir.",
                ResponsiblePerson = "Ali Veli"
            }
            );
              list1.Add(new Announcement()  {
                ID = 1,
                Title = "Duyuru Başlığı",
                Text = "Bu bir duyuru metnidir.",
                ResponsiblePerson = "Ali Veli"
            }
            );
              list1.Add(new Announcement()  {
                ID = 1,
                Title = "Duyuru Başlığı",
                Text = "Bu bir duyuru metnidir.",
                ResponsiblePerson = "Ali Veli"
            }
            );
              list1.Add(new Announcement()  {
                ID = 1,
                Title = "Duyuru Başlığı",
                Text = "Bu bir duyuru metnidir.",
                ResponsiblePerson = "Ali Veli"
            }
            );
              list1.Add(new Announcement()  {
                ID = 1,
                Title = "Duyuru Başlığı",
                Text = "Bu bir duyuru metnidir.",
                ResponsiblePerson = "Ali Veli"
            }
            );





        }
        public static List<Announcement> annlist{get{return list;}}
        

    

    }
}