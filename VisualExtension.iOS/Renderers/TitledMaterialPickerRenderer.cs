using System;
using VisualExtension;
using VisualExtension.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Picker), typeof(TitledMaterialPickerRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.iOS.Renderers
{
    public class TitledMaterialPickerRenderer : MaterialPickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                Control.Placeholder = Element.Title;
                Control.HidesPlaceholderOnInput = false;
            }
        }

        protected override void UpdatePlaceholder()
        {
            //This method intentionally blank
            //The base implementation hides the place holder when selected
            //This material renderer automatically shrinks the placeholder
            //I may need to revisit this
        }
    }
}
