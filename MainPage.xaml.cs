namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        List<string> list = ["1", "2", "3", "4", "5"];
        ResultList.ItemsSource = list;
        ResultList.SelectedItem = null;
    }

    private void ResultList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private async void CounterBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new NewPage1());
    }
}

