using System;
using VisualExtension;
using VisualExtension.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;

[assembly: ExportRenderer(typeof(ProgressBar), typeof(ExtendedMaterialProgressBarRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.iOS.Renderers
{
    public class ExtendedMaterialProgressBarRenderer : MaterialProgressBarRenderer
    {
        public ExtendedMaterialProgressBarRenderer()
        {
        }
    }
}
