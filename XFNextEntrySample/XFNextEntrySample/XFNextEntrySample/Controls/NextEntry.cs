using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace XFNextEntrySample.Controls
{
    public class NextEntry : Entry
    {
        public static readonly BindableProperty NextViewProperty =
            BindableProperty.Create(nameof(NextView), typeof(View), typeof(NextEntry));

        public View NextView
        {
            get => (View)GetValue(NextViewProperty);
            set => SetValue(NextViewProperty, value);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            Completed += (sender, e) => NextView?.Focus();
        }
    }
}
