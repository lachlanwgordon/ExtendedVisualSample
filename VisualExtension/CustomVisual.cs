using System;
using Xamarin.Forms;

namespace VisualExtension
{
    /// <summary>
    /// This is my custom Visual that inherits from IVisual. There's no real code here. Any renderer that references CustomVisual will be used when that Control uses Visual="Custom"
    /// </summary>
    public class CustomVisual : IVisual
    {
        public CustomVisual()
        {
        }
    }
}
