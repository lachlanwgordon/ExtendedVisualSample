using System;
using Android.Content;
using VisualExtension;
using VisualExtension.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;

[assembly: ExportRenderer(typeof(Slider), typeof(ExtendedMaterialSliderRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.Droid.Renderers
{
    public class ExtendedMaterialSliderRenderer : MaterialSliderRenderer
    {
        public ExtendedMaterialSliderRenderer(Context context) : base(context)
        {
        }
    }
}
