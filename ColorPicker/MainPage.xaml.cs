namespace ColorPicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GenarateRandomColor_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);

            RedSlider.Value = red;
            GreenSlider.Value = green;
            BlueSlider.Value = blue;

            Color color = Color.FromRgb(red, green, blue);
            box_thing.BackgroundColor = color;
            hex_code.Text = color.ToHex();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var red = (int)RedSlider.Value;
            var green = (int)GreenSlider.Value;
            var blue = (int)BlueSlider.Value;

            Color color = Color.FromRgb(red, green, blue);
            hex_code.Text = color.ToHex();

            box_thing.BackgroundColor = color;
            contentPage.BackgroundColor = color;
        }

    }
}

