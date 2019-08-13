using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Extended;

namespace InfiniteListViewSample
{
    class MainViewModel:INotifyPropertyChanged
    {
        private const int PageSize = 10;
        readonly DataService dataService = new DataService();
        private bool isBusy;
        public InfiniteScrollCollection<ForumData> Items { get; set; }

        public MainViewModel()
        {
            Items = new InfiniteScrollCollection<ForumData>
            {
                OnLoadMore = async () =>
                {
                    IsBusy = true;
                    // load the next page
                    var page = Items.Count / PageSize;
                    var items = await dataService.GetForumDataAsync(page + 1, PageSize);

                    IsBusy = false;
                    // return the items that need to be added
                    return items;
                    //njkjk
                },
                OnCanLoadMore = () =>
                {
                    int testvar2 = dataService.GetCountAsync();
                    int testvar = Items.Count;
                    return Items.Count != 35;
                }
            };
            
            AddItems();
        }



        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        public async void AddItems()
        {
            var items = await dataService.GetForumDataAsync(0, 10);
            Items.AddRange(items);
        }




        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }


    public class DataService
    {
        private List<ForumData> MainListViewData = new List<ForumData>
            {
                new ForumData()
                {
                    Name="Aswin",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="I came to know that his death was not obvious and there was some mystery surrounding it.",
                    Heading="What is the contreversy regarding the death of Netaji Subash Chandra Bose? Please clarify",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Navaneeth",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Naveen",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Aswin",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="I came to know that his death was not obvious and there was some mystery surrounding it.",
                    Heading="What is the contreversy regarding the death of Netaji Subash Chandra Bose? Please clarify",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Navaneeth",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Naveen",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Aswin",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="I came to know that his death was not obvious and there was some mystery surrounding it.",
                    Heading="What is the contreversy regarding the death of Netaji Subash Chandra Bose? Please clarify",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Navaneeth",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Naveen",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Aswin",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="I came to know that his death was not obvious and there was some mystery surrounding it.",
                    Heading="What is the contreversy regarding the death of Netaji Subash Chandra Bose? Please clarify",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Navaneeth",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Naveen",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Aswin",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="I came to know that his death was not obvious and there was some mystery surrounding it.",
                    Heading="What is the contreversy regarding the death of Netaji Subash Chandra Bose? Please clarify",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Navaneeth",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Naveen",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Aswin",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="I came to know that his death was not obvious and there was some mystery surrounding it.",
                    Heading="What is the contreversy regarding the death of Netaji Subash Chandra Bose? Please clarify",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Navaneeth",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Naveen",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Aswin",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="I came to know that his death was not obvious and there was some mystery surrounding it.",
                    Heading="What is the contreversy regarding the death of Netaji Subash Chandra Bose? Please clarify",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Navaneeth",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Naveen",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Aswin",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="I came to know that his death was not obvious and there was some mystery surrounding it.",
                    Heading="What is the contreversy regarding the death of Netaji Subash Chandra Bose? Please clarify",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Navaneeth",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Naveen",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="Avinash",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="vsdvsdv",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="vsvsdv",
                    Description="I came to know that his death was not obvious and there was some mystery surrounding it.",
                    Heading="What is the contreversy regarding the death of Netaji Subash Chandra Bose? Please clarify",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="vdvsvsvsd",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="aswffgdffsdvsdvsdvsv",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                },
                new ForumData()
                {
                    Name="nottaken",
                    Description="GSLV-F11 successfully launched GSAT-7A, ISRO's 39th communication satellite",
                    Heading="How many Satelllites did GSLV carry in it's last launch?",
                    ImgUrl="man.png",
                    PostedOn="Just Now",
                    Tag="GK"
                }
            };


        
        public async Task<List<ForumData>> GetForumDataAsync(int pageindex, int pagesize)
        {
            await Task.Delay(2000);
            return MainListViewData.Skip(pageindex * pagesize).Take(pagesize).ToList();
        }

        public int GetCountAsync()
        {
            return MainListViewData.Count;
        }
    }
}

