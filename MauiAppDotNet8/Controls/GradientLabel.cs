using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppDotNet8.Controls
{
    public class GradientLabel : Label
    {
        public static readonly BindableProperty TextColor1Property = BindableProperty.Create(
        propertyName: nameof(TextColor1),
        returnType: typeof(Color),
        declaringType: typeof(GradientLabel),
        defaultValue: Colors.Red);
        public Color TextColor1
        {
            get => (Color)GetValue(TextColor1Property);
            set => SetValue(TextColor1Property, value);
        }
        public static readonly BindableProperty TextColor2Property = BindableProperty.Create(
            propertyName: nameof(TextColor2),
            returnType: typeof(Color),
            declaringType: typeof(GradientLabel),
            defaultValue: Colors.Green);
        public Color TextColor2
        {
            get => (Color)GetValue(TextColor2Property);
            set => SetValue(TextColor2Property, value);
        }

    }

}
