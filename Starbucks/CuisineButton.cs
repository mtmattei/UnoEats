using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Starbucks
{
    public sealed class CuisineButton : Button
    {
        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register(nameof(LabelText), typeof(string), typeof(CuisineButton), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty IconContentProperty =
            DependencyProperty.Register(nameof(IconContent), typeof(object), typeof(CuisineButton), new PropertyMetadata(null));

        public string LabelText
        {
            get => (string)GetValue(LabelTextProperty);
            set => SetValue(LabelTextProperty, value);
        }

        public object IconContent
        {
            get => GetValue(IconContentProperty);
            set => SetValue(IconContentProperty, value);
        }

        public CuisineButton()
        {
            this.DefaultStyleKey = typeof(CuisineButton);
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
    }
}
