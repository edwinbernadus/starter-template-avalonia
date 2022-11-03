using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MyApp.Interface;
using MyApp.Models;
using Newtonsoft.Json;

namespace MyApp.ViewModels
{
    public class MvListPage : INotifyPropertyChanged
    {
        private readonly IGoBack _goBack;
        public string InfoListPage { get; set; } = "";


        private List<MvListPageDetail> _items = new List<MvListPageDetail>();

        public List<MvListPageDetail> Items
        {
            get => _items;
            set
            {
                if (Equals(value, _items)) return;
                _items = value;
                OnPropertyChanged();
            }
        }

        private bool _isVisibleLoading = false;

        public bool IsVisibleLoading
        {
            get => _isVisibleLoading;
            set
            {
                if (value == _isVisibleLoading) return;
                _isVisibleLoading = value;
                OnPropertyChanged();
            }
        }

        private bool _isVisibleContent = false;
        private string _displayInfoAlert;

        public bool IsVisibleContent
        {
            get => _isVisibleContent;
            set
            {
                if (value == _isVisibleContent) return;
                _isVisibleContent = value;
                OnPropertyChanged();
            }
        }

        public string DisplayInfoAlert
        {
            get => _displayInfoAlert;
            set
            {
                if (value == _displayInfoAlert) return;
                _displayInfoAlert = value;
                OnPropertyChanged();
            }
        }


        public MvListPage(IGoBack goBack)
        {
            _goBack = goBack;
        }

        public void OnGoBackClickCommand()
        {
            _goBack.DoGoBack();
        }

        public async Task GetContentFromWeb()
        {

            this.DisplayInfoAlert = "[result from info button]";
            // hint_show_loading_indicator
            this.IsVisibleLoading = true;
            this.IsVisibleContent = false;
            var httpClient = new HttpClient();
            // hint_loading_webservice
            var url = "https://jsonplaceholder.typicode.com/albums";
            var content = await httpClient.GetStringAsync(url);
            var items = JsonConvert.DeserializeObject<List<PlaceHolderItem>>(content);
            this.Items = items
                .Take(10)
                .Select(x => new MvListPageDetail(this)
            {
                id = x.id,
                userId = x.userId,
                title = x.title
            }).ToList();
            this.IsVisibleLoading = false;
            this.IsVisibleContent = true;
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}