using System;
using Android.Content;
using VisualExtension;
using VisualExtension.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;

[assembly: ExportRenderer(typeof(TimePicker), typeof(ExtendedMaterialTimePickerRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.Droid.Renderers
{
    public class ExtendedMaterialTimePickerRenderer : MaterialTimePickerRenderer
    {
        public ExtendedMaterialTimePickerRenderer(Context context) : base(context)
        {
        }
    }
}
