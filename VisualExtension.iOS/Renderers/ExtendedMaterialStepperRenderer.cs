using System;
using VisualExtension;
using VisualExtension.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;

[assembly: ExportRenderer(typeof(Stepper), typeof(ExtendedMaterialStepperRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.iOS.Renderers
{
    public class ExtendedMaterialStepperRenderer : MaterialStepperRenderer
    {
        
    }
}
