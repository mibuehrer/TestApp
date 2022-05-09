using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Diagnostics;
using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.Effects;
using Microsoft.Graphics.Canvas.Text;
using Microsoft.Graphics.Canvas.UI.Xaml;
using Microsoft.UI;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TestApp.Controls
{
    public sealed partial class Win2DCtrl2 : UserControl
    {
        public static DependencyProperty LabelProperty =
             DependencyProperty.Register("Label", typeof(string), typeof(Win2DCtrl2), null);
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public Win2DCtrl2()
        {
            this.InitializeComponent();
        }

        private void Canvas_Draw(Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl sender, Microsoft.Graphics.Canvas.UI.Xaml.CanvasDrawEventArgs args)
        {
            string test = Label;
            Debug.Assert(!string.IsNullOrEmpty(test));
            test = "From Canvas: " + test;
            var tf = new CanvasTextFormat
            {
                FontFamily = "Arial",
                FontSize = 12,
                WordWrapping = CanvasWordWrapping.NoWrap
            };

            if (this.DataContext == null) test += " (NULL!)";
            args.DrawingSession.DrawText(test, 0, 0, Colors.Black, tf);
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            if (Canvas!=null)
            {
                Canvas.RemoveFromVisualTree();
                Canvas = null;
            }

        }
    }
}
