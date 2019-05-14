using System;
using VisualExtension;
using VisualExtension.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;

[assembly: ExportRenderer(typeof(Slider), typeof(ExtendedMaterialSliderRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.iOS.Renderers
{
    public class ExtendedMaterialSliderRenderer : MaterialSliderRenderer
    {
        public ExtendedMaterialSliderRenderer()
        {
        }
    }
}
