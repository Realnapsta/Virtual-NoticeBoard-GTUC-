using System;
using System.Collections.Generic;
using VirtualNoticeBoardGTUC.Models;
using VirtualNoticeBoardGTUC.Services;

namespace VirtualNoticeBoardGTUC.ViewModels
{
    public class NoticeViewModel
    {
        public List<NoticeModel> Notices { set; get; }

        public NoticeViewModel()
        {
            Notices = new NoticeService().notices();
        }
    }
}
