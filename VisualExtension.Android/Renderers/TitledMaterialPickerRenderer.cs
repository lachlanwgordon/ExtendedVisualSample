using System;
using Android.Content;
using VisualExtension;
using VisualExtension.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;

[assembly: ExportRenderer(typeof(Picker), typeof(TitledMaterialPickerRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.Droid.Renderers
{
    public class TitledMaterialPickerRenderer : MaterialPickerRenderer
    {
        public TitledMaterialPickerRenderer(Context context) : base(context)
        {

        }

        protected override void UpdatePlaceHolderText()
        {
            base.UpdatePlaceHolderText();
            InputLayout.HintEnabled = true;
            InputLayout.Hint = Element.Title;
        }

        MaterialPickerTextInputLayout InputLayout;
        protected override MaterialPickerTextInputLayout CreateNativeControl()
        {
            InputLayout = base.CreateNativeControl();
            return InputLayout;
        }

    }
}
