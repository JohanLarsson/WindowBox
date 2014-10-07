namespace WindowBox
{
    using System.Windows;

    public class SpexialWindow : Window
    {
        public static readonly DependencyProperty SomeTextProperty = DependencyProperty.Register(
            "SomeText",
            typeof(string),
            typeof(SpexialWindow),
            new FrameworkPropertyMetadata(default(string)));

        static SpexialWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SpexialWindow), new FrameworkPropertyMetadata(typeof(SpexialWindow)));
        }

        public string SomeText
        {
            get { return (string)GetValue(SomeTextProperty); }
            set { SetValue(SomeTextProperty, value); }
        }
    }
}
