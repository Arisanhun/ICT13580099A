using Xamarin.Forms;

namespace ICT13580099A
{
    public partial class ICT13580099APage : ContentPage
    {


        public ICT13580099APage()
        {
            InitializeComponent();

            okBotton.Clicked += OkBotton_Clicked1;
            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");

            mySlider.ValueChanged += MySlider_ValueChanged1;
            myStepper.ValueChanged += MyStepper_ValueChanged;



        }

        void OkBotton_Clicked1(object sender, System.EventArgs e)
        {
            firstNamelabel.Text = firstNameEntry.Text;
        }

        void MySlider_ValueChanged1(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();

        }

        void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }
    }
}