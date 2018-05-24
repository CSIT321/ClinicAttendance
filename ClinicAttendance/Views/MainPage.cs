using System;
using Xamarin.Forms;

namespace ClinicAttendance
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page calendarPage, tasksPage, infoPage = null;

            switch (Device.RuntimePlatform)
            {
                // login screen
                // calendar, tasks, info
                case Device.iOS:
                    calendarPage = new NavigationPage(new ItemsPage())
                    {
                        Title = "Calendar"
                    };

                    tasksPage = new NavigationPage(new AboutPage())
                    {
                        Title = "Tasks"
                    };
                    infoPage = new NavigationPage(new InfoPage())
                    {
                        Title = "Info"
                    };
                    calendarPage.Icon = "tab_feed.png";
                    tasksPage.Icon = "tab_about.png";
                    infoPage.Icon = "tab_about.png";
               

                    break;
                default:
                    calendarPage = new ItemsPage()
                    {
                        Title = "Calendar"
                    };

                    tasksPage =new AboutPage()
                    {
                        Title = "Tasks"
                    };
                    infoPage = new InfoPage()
                    {
                        Title = "Info"
                    };

                    //aboutPage = new AboutPage()
                    //{
                    //    Title = "About"
                    //};
                    break;
            }

            Children.Add(calendarPage);
            Children.Add(tasksPage);
            Children.Add(infoPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
