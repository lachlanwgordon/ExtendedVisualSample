using System;
using Android.Content;
using VisualExtension;
using VisualExtension.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;
[assembly: ExportRenderer(typeof(ActivityIndicator), typeof(ExtendedMaterialActivityIndicatorRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.Droid.Renderers
{
    public class ExtendedMaterialActivityIndicatorRenderer : MaterialActivityIndicatorRenderer
    {
        public ExtendedMaterialActivityIndicatorRenderer(Context context) : base(context)
        {
        }
    }
}
