using System;
using System.Collections.Generic;
using Virtual_NoticeBoard_GTUC_;
using VirtualNoticeBoardGTUC.Models;
using Xamarin.Forms;
using SQLite;
using VirtualNoticeBoardGTUC.Helpers;
using VirtualNoticeBoardGTUC.Views.Main;

namespace VirtualNoticeBoardGTUC.Views.Startup
{
    public partial class ActivatePage : ContentPage
    {
        public ActivatePage()
        {

            this.BindingContext = this;

            this.IsBusy = false;
            InitializeComponent();
        }

        async void Activate_Button_Clicked(System.Object sender, System.EventArgs e)
        {

            var db = new SQLiteConnection(App.DatabaseLocation);
            db.CreateTable<Students>();

            this.IsBusy = true;
            bool isindexEntry = string.IsNullOrEmpty(indexEntry.Text);
            bool isfullNameEntry = string.IsNullOrEmpty(fullNameEntry.Text);
            bool iscourseEntry = string.IsNullOrEmpty(courseEntry.Text);
            bool islevelEntry = string.IsNullOrEmpty(levelEntry.Text);
            bool ispinEntry = string.IsNullOrEmpty(pinEntry.Text);
            bool isComfirmPinEmpty = string.IsNullOrEmpty(confirmPinEntry.Text);
            Activatebtn.IsEnabled = false;

            try
            {
                if (isindexEntry || isfullNameEntry || iscourseEntry || islevelEntry || ispinEntry || isComfirmPinEmpty)
                {
                    await DisplayAlert("Failed", "please fill all entries", "Try again");
                    Activatebtn.IsEnabled = true;
                }
                else
                {
                    if (confirmPinEntry.Text != pinEntry.Text)
                    {
                        await DisplayAlert("Failed", "password do not match", "try Again");
                        Activatebtn.IsEnabled = true;

                    }
                    else
                    {
                        Students student = new Students()
                        {
                            FullName = fullNameEntry.Text,
                            IndexNumber = indexEntry.Text,
                            Level = levelEntry.Text,
                            Course = courseEntry.Text,
                            Pin = pinEntry.Text


                        };

                        db.Insert(student);
                        db.Close();

                        App.currentstudent = student;
                     
                        await DisplayAlert("Success", "Account has sucessfully been created, Please Add Face Id to continue", "OK");

                        Settings.LastUserName = student.IndexNumber;

                        Application.Current.MainPage = new MainShell();

                        Activatebtn.IsEnabled = false;

                    }
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("ERROR", "Something went wrong", "Cancel", "try again");
                string error_text = ex.ToString();
                Activatebtn.IsEnabled = true;

            }

            this.IsBusy = false;
            Activatebtn.IsEnabled = true;
        }
    }
}