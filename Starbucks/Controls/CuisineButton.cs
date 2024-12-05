using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbucks.Controls
{
    public sealed class CuisineButton : Button
    {
        public static readonly DependencyProperty IconContentProperty =
            DependencyProperty.Register(
                nameof(IconContent),
                typeof(object),
                typeof(CuisineButton),
                new PropertyMetadata(null));

        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register(
                nameof(LabelText),
                typeof(string),
                typeof(CuisineButton),
                new PropertyMetadata(string.Empty));

        public object IconContent
        {
            get => GetValue(IconContentProperty);
            set => SetValue(IconContentProperty, value);
        }

        public string LabelText
        {
            get => (string)GetValue(LabelTextProperty);
            set => SetValue(LabelTextProperty, value);
        }

        public CuisineButton()
        {
            this.DefaultStyleKey = typeof(CuisineButton);
        }
    }
}
