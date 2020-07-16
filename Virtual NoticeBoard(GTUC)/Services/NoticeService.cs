using System;
using System.Collections.Generic;
using VirtualNoticeBoardGTUC.Models;

namespace VirtualNoticeBoardGTUC.Services
{
    public class NoticeService
    {
        public List<NoticeModel> notices()
        {
            return new List<NoticeModel>
            {
                new NoticeModel(){Id= 1, Description= "This is to notify all students that final exams is due on 24th of june",
                    IssuedDate = DateTime.UtcNow, ExpiryDate = Convert.ToDateTime("15/06/2020"),
                    Level= "All", Name = "Final Exams Notice", Tags= "Exams , Gtuc"},

                new NoticeModel(){Id= 1, Description= "This is to remind all students that the final fee payment od 40% is due",
                    IssuedDate = DateTime.UtcNow, ExpiryDate = Convert.ToDateTime("15/06/2020"),
                    Level= "All", Name = "Final Fee Payment", Tags= "Fees , Gtuc"},

                new NoticeModel(){Id= 1, Description= "There is going to be a falcuty meeting for all FOCIS students",
                    IssuedDate = DateTime.UtcNow, ExpiryDate = Convert.ToDateTime("15/06/2020"),
                    Level= "All", Name = "Falcuty Meeting", Tags= "falcuty , Gtuc"},

                new NoticeModel(){Id= 1, Description= "GTUC Campus praise is to be held on 15th of june",
                    IssuedDate = DateTime.UtcNow, ExpiryDate = Convert.ToDateTime("15/06/2020"),
                    Level= "All", Name = "Church Service", Tags= "service , Gtuc"},

                new NoticeModel(){Id= 1, Description= "All level 400 students are to submit their project for defense in their respective falcuties",
                    IssuedDate = DateTime.UtcNow, ExpiryDate = Convert.ToDateTime("15/06/2020"),
                    Level= "All", Name = "Project Defense", Tags= "priject , Gtuc"},
            };
        }
    }
}
