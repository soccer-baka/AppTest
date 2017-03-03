using Xamarin.Forms;

namespace AppTest
{
    class ListItem
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public ListItem(string name, string comment)
        {
            Name = name;
            Comment = comment;
        }
    }

    public partial class AppTestPage : ContentPage
    {
        public AppTestPage()
        {
            InitializeComponent();

            ListItem[] items = { new ListItem("test 1", "comment 1"), new ListItem("test 2", "comment 2"), new ListItem("test 3", "comment 3") };
            listView.ItemsSource = items;
        }
    }
}
