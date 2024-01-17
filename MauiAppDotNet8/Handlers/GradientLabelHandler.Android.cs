using Android.Graphics;
using AndroidX.AppCompat.Widget;
using MauiAppDotNet8.Controls;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Handlers;
using Color = Android.Graphics.Color;

namespace MauiAppDotNet8.Handlers
{
    public partial class GradientLabelHandler : LabelHandler
    {
        private GradientLabel gradientLabel;

        protected override void ConnectHandler(AppCompatTextView platformView)
        {
            gradientLabel = (GradientLabel)VirtualView;

            var width = platformView.Paint.MeasureText(gradientLabel.Text);
            var c1 = gradientLabel.TextColor1.ToAndroid();
            var c2 = gradientLabel.TextColor2.ToAndroid();


            //Custom your on direction, colors, and Tile Mode here
            
            var textShader = new LinearGradient(0, width, 0, platformView.TextSize, 
                colors: new int[] 
                { 
                    c1,
                    c2,
                    Color.Green, // demo
                    Color.OrangeRed // demo
                },
                null,
                Shader.TileMode.Clamp);

            platformView.Paint.SetShader(textShader);

            base.ConnectHandler(platformView);
        }

        protected override void DisconnectHandler(AppCompatTextView platformView)
        {
            base.DisconnectHandler(platformView);

            gradientLabel = null;
        }
    }
}
