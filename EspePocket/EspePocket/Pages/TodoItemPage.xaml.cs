using EspePocket.Models;
using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoItemPage : ContentPage
    {
        double value = 0;
        public TodoItemPage()
        {
            InitializeComponent();
            var todoItem = (TodoItem)BindingContext;
            Dictionary<string, double> notificationTime = new Dictionary<string, double>
            {
                 { "1 minuto", 1 },
                { "5 minutos", 5 }, { "15 minutos", 15 },
                { "25 minutos", 25 }, { "45 minutos", 45 },
                { "1 hora", 60 }, { "2 horas", 120 },
                { "3 horas", 180}, { "12 horas", 720},
                { "24 horas", 1440 }, { "2 días", 2880},
                { "1 semana", 10080}
            };

            foreach (string times in notificationTime.Keys)
            {
                PickMe.Items.Add(times);
            }
            PickMe.SelectedIndexChanged += (sender, args) =>
            {
                if (PickMe.SelectedIndex != -1)
                {
                    string number = PickMe.Items[PickMe.SelectedIndex];
                    value = notificationTime[number];

                }
                else
                {
                    string number = PickMe.Items[PickMe.SelectedIndex];
                    value = notificationTime[number];
                }
            };
            Esverdad();
        }
        public void Esverdad()
        {
            var todoItem = (TodoItem)BindingContext;
            if (IsItDone.IsToggled == true)
            {
                CrossLocalNotifications.Current.Cancel(todoItem.ID);
            }
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            await App.Database.SaveItemAsync(todoItem);
            await Navigation.PopAsync();

            CrossLocalNotifications.Current.Show("EspePocket - Tareas", "Recuerda terminar: " + Titles.Text + "!", todoItem.ID, DateTime.Now.AddMinutes(value));
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            await App.Database.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
            CrossLocalNotifications.Current.Cancel(todoItem.ID);
        }

        public void OnCancelClicked(object sender, EventArgs e)
        {
            DisplayAlert("Alerta", "El recordatorio fue cancelado si desea crear uno nuevo vuelva a guardar la nota", "OK");
            var todoItem = (TodoItem)BindingContext;
            //await Navigation.PopAsync();
            CrossLocalNotifications.Current.Cancel(todoItem.ID);
        }

        void OnSpeakClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            DependencyService.Get<ITextToSpeech>().Speak(todoItem.Name + " " + todoItem.Notes);
        }
    }
}