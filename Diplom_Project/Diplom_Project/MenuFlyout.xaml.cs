using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Diplom_Project
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuFlyout : ContentPage
    {
        public ListView ListView;

        public MenuFlyout()
        {
            InitializeComponent();

            BindingContext = new MenuFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class MenuFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MenuFlyoutMenuItem> MenuItems { get; set; }

            public MenuFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MenuFlyoutMenuItem>(new[]
                {
                    new MenuFlyoutMenuItem { Id = 0, Title = "Тема 1 Цифровая граммотность и информационная культура" , TargetType = typeof (TabPage)},
                    new MenuFlyoutMenuItem { Id = 1, Title = "Тема 2 Искусственный интилект" },
                    new MenuFlyoutMenuItem { Id = 2, Title = "Тема 3 Компьютерные сети" },
                    new MenuFlyoutMenuItem { Id = 3, Title = "Тема 4 Коммуникация в интернете" },
                    new MenuFlyoutMenuItem { Id = 4, Title = "Тема 5 Облачные технологии" },
                    new MenuFlyoutMenuItem { Id = 5, Title = "Тема 6 Большие данные" },
                    new MenuFlyoutMenuItem { Id = 6, Title = "Тема 7 Нейросети и коммуникация" },
                    new MenuFlyoutMenuItem { Id = 7, Title = "Тема 8 Социальные сети" },
                    new MenuFlyoutMenuItem { Id = 8, Title = "Тема 9 Digital экология" },
                    new MenuFlyoutMenuItem { Id = 9, Title = "Тема 10 Безопасность в интернете" },
                    new MenuFlyoutMenuItem { Id = 10, Title = "Тема 11 Приватность в цифровом мире" },
                    new MenuFlyoutMenuItem { Id = 11, Title = "Тема 12 Персональные помощники" },
                    new MenuFlyoutMenuItem { Id = 12, Title = "Тема 13 Цифровые сервисы" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
        private async void Item_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new TabPage());

        }
    }
}