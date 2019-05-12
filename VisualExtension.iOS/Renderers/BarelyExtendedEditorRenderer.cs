using System;
using VisualExtension;
using VisualExtension.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;

[assembly: ExportRenderer(typeof(Editor), typeof(BarelyExtendedEditorRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.iOS.Renderers
{
    public class BarelyExtendedEditorRenderer : MaterialEditorRenderer
    {
        public BarelyExtendedEditorRenderer()
        {
        }
    }
}
