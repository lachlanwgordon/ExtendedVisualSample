using System;
using VisualExtension;
using VisualExtension.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(BarelyExtendedEntryRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.iOS.Renderers
{
    public class BarelyExtendedEntryRenderer : MaterialEntryRenderer
    {
        public BarelyExtendedEntryRenderer()
        {
        }
    }
}
