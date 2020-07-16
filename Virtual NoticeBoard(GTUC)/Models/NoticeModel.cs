using System;
namespace VirtualNoticeBoardGTUC.Models
{
    public class NoticeModel
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public string Name { get; set; }
        public String Description { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Tags { get; set; }
    }

}
