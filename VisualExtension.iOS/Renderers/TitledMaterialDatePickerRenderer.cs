using System;
using VisualExtension;
using VisualExtension.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;

[assembly: ExportRenderer(typeof(DatePicker), typeof(TitledMaterialDatePickerRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.iOS.Renderers
{
    public class TitledMaterialDatePickerRenderer : MaterialDatePickerRenderer
    {
        public TitledMaterialDatePickerRenderer()
        {
        }
    }
}
