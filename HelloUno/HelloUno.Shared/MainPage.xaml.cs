using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloUno
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Todo> TodoList { get; }

        public MainPage()
        {
            this.InitializeComponent();
            TodoList = new ObservableCollection<Todo>();
        }

        private void RecordButton_Click(object sender, RoutedEventArgs e)
        {
            TodoList.Add(new Todo
            {
                TodoId = Guid.NewGuid().ToString(),
                Description = TodoText.Text,
                CreatedDate = DateTime.Now,
                Done = false
            });

            TodoText.Text = "";
        }
    }
}
