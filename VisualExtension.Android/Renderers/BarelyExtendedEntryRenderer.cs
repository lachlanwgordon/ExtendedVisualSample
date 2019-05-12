using System;
using Android.Content;
using VisualExtension;
using VisualExtension.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(BarelyExtendedEntryRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.Droid.Renderers
{
    /// <summary>
    /// This Class only exists so that I can choose to use the classis slider in my CustomVisual where I usually use MaterialRenderers
    /// </summary>
    public class BarelyExtendedEntryRenderer : MaterialEntryRenderer
    {
        public BarelyExtendedEntryRenderer(Context context) : base(context)
        {
        }
    }
}
