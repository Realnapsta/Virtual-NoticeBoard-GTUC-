using System;

using Virtual_NoticeBoard_GTUC_.Models;

namespace Virtual_NoticeBoard_GTUC_.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
