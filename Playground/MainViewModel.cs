using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Playground
{
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<string> Collection { get; set; }

        public MainViewModel()
        {
            Collection = new ObservableCollection<string>
            {
                "Cat",
                "Dog",
                "Wolf",
                "Tiger",
                "Dragon",
            };
        }
    }
}
