using System;
using Android.Content;
using VisualExtension;
using VisualExtension.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Material.Android;
using Xamarin.Forms.Platform.Android;

//[assembly: ExportRenderer(typeof(Button), typeof(AnyCaseButtonRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.Droid.Renderers
{
    public class AnyCaseButtonRenderer : MaterialButtonRenderer
    {
        public AnyCaseButtonRenderer(Context context) : base(context)
        {
        }

        public AnyCaseButtonRenderer(Context context, BindableObject element) : base(context, element)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                Control.SetAllCaps(false);
            }
        }

        public static void VisualInit()
        {
            var export = new ExportRendererAttribute(typeof(Button), typeof(AnyCaseButtonRenderer), new[] { typeof(CustomVisual) });
            Xamarin.Forms.Internals.Registrar.RegisterRenderers();

        }
    }

    
}
