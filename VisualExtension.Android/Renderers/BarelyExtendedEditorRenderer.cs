using System;
using Android.Content;
using VisualExtension;
using VisualExtension.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;

[assembly: ExportRenderer(typeof(Editor), typeof(BarelyExtendedEditorRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.Droid.Renderers
{
    public class BarelyExtendedEditorRenderer : MaterialEditorRenderer
    {
        public BarelyExtendedEditorRenderer(Context context) : base(context)
        {
        }
    }
}
