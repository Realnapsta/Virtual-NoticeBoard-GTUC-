using System;
using System.Collections.Generic;
using VirtualNoticeBoardGTUC.Models;
using Xamarin.Forms;

namespace VirtualNoticeBoardGTUC.Views.Main
{
    public partial class AnnounceMentsPage : ContentPage
    {
        public AnnounceMentsPage()
        {
            InitializeComponent();

            CVNotices.SelectionChanged += CVNotices_SelectionChanged;
        }

        private void CVNotices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          var notices = e.CurrentSelection;
          string msg = string.Empty;
          msg = "Selected Notice \n";
          for(int i = 0; i < notices.Count; i++)
        {
            var notice = notices[i] as NoticeModel;
            msg += $"\n{notice.Description} \n \n sent on : ({notice.IssuedDate})";
         }

          DisplayAlert("Notice", msg, "Ok");

        }
    }
}
