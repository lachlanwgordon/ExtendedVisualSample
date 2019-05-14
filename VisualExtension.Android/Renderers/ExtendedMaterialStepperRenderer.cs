using System;
using Android.Content;
using VisualExtension;
using VisualExtension.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;

[assembly: ExportRenderer(typeof(Stepper), typeof(ExtendedMaterialStepperRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.Droid.Renderers
{
    public class ExtendedMaterialStepperRenderer : MaterialStepperRenderer
    {
        public ExtendedMaterialStepperRenderer(Context context) : base(context)
        {
        }
    }
}
