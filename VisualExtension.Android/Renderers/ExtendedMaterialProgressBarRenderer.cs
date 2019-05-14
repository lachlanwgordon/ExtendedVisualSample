using System;
using Android.Content;
using VisualExtension;
using VisualExtension.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;

[assembly: ExportRenderer(typeof(ProgressBar), typeof(ExtendedMaterialProgressBarRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.Droid.Renderers
{
    public class ExtendedMaterialProgressBarRenderer : MaterialProgressBarRenderer
    {
        public ExtendedMaterialProgressBarRenderer(Context context) : base(context)
        {
        }
    }
}
