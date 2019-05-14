using System;
using VisualExtension;
using VisualExtension.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;

[assembly: ExportRenderer(typeof(TimePicker), typeof(ExtendedMaterialTimePickerRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.iOS.Renderers
{
    public class ExtendedMaterialTimePickerRenderer : MaterialTimePickerRenderer
    {
        
    }
}
