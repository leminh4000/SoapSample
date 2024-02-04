using ServiceReference1;

namespace SoapSample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";


            CalculatorSoap calculator = new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap);
            var result = calculator.MultiplyAsync(10, 9);
            var test = await result;
            CounterBtn.Text = $"Clicked {test} times";
            SemanticScreenReader.Announce(CounterBtn.Text);

        }

    }

}
       