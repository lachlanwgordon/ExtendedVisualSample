using System;
using Android.Content;
using VisualExtension;
using VisualExtension.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;

[assembly: ExportRenderer(typeof(DatePicker), typeof(TitledMaterialDatePickerRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.Droid.Renderers
{
    public class TitledMaterialDatePickerRenderer : MaterialDatePickerRenderer
    {
        public TitledMaterialDatePickerRenderer(Context context) : base(context)
        {
        }
    }
}
