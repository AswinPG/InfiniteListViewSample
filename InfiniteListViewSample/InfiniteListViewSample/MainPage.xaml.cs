using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Extended;

namespace InfiniteListViewSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        private const int PageSize = 20;
        public MainPage()
        {
            InitializeComponent();

            Items = new InfiniteScrollCollection<ForumData>
            {
                OnLoadMore = async () =>
                {
                    // load the next page
                    var page = Items.Count / PageSize;
                    var items = await dataSource.GetItemsAsync(page + 1, PageSize);

                    // return the items that need to be added
                    return items;
                    //njkjk
                }
            };

        }
        public InfiniteScrollCollection<ForumData> Items { get; }
    }
}
