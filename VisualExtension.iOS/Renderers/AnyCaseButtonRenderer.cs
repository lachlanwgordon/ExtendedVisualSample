using System;
using System.ComponentModel;
using UIKit;
using VisualExtension;
using VisualExtension.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Button), typeof(AnyCaseButtonRenderer), new[] {typeof(CustomVisual) } ) ]
namespace VisualExtension.iOS.Renderers
{
    public class AnyCaseButtonRenderer : MaterialButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                Control.UppercaseTitle = false;
            }
        }
    }
}
