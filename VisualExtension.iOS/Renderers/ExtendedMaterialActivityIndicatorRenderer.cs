using System;
using VisualExtension;
using VisualExtension.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;

[assembly: ExportRenderer(typeof(ActivityIndicator), typeof(ExtendedMaterialActivityIndicatorRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.iOS.Renderers
{
    public class ExtendedMaterialActivityIndicatorRenderer : MaterialActivityIndicatorRenderer
    {
        public ExtendedMaterialActivityIndicatorRenderer()
        {
        }
    }
}
