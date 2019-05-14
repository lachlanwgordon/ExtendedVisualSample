using System;
using Android.Content;
using VisualExtension;
using VisualExtension.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;

[assembly: ExportRenderer(typeof(Frame), typeof(ExtendedMaterialFrameRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.Droid.Renderers
{
    public class ExtendedMaterialFrameRenderer : MaterialFrameRenderer
    {
        public ExtendedMaterialFrameRenderer(Context context) : base(context)
        {
        }
    }
}
