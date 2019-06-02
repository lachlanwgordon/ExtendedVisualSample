using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using UIKit;
using VisualExtension;
using VisualExtension.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;
using Xamarin.Forms.Platform.iOS;
using static Xamarin.Forms.VisualMarker;

//[assembly: ExportRenderer(typeof(Button), typeof(AnyCaseButtonRenderer), new[] { typeof(CustomVisual) })]
namespace VisualExtension.iOS.Renderers
{
    public class AnyCaseButtonRenderer : MaterialButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                Control.UppercaseTitle = false;
            }
        }

        public static void VisualInit(Type overRideRendererType = null)
        {
            //var formsAssembly = System.Reflection.Assembly.GetAssembly(typeof(Xamarin.Forms.Application));

            

            var materialAssembly = Assembly.GetAssembly(typeof(Xamarin.Forms.Material.iOS.MaterialButtonRenderer));

            var name = "Xamarin.Forms.Material.iOS";//investigate a type safe way
            var baseRendererTypes = materialAssembly.ExportedTypes.Where(x => x.IsClass && x.Namespace == name);
            //var types = PlatformAssembly.ExportedTypes;

            var overRideElementProperty = overRideRendererType?.GetRuntimeProperties().FirstOrDefault(x => x.Name == "Element");

            foreach (var baseRendererType in baseRendererTypes)
            {
                if (baseRendererType.Name.Contains("Renderer"))
                {
                    
                    var baseRendererElementProperty = baseRendererType.GetRuntimeProperties().FirstOrDefault(x => x.Name == "Element");
                    var rendererType = baseRendererType;

                    //if (overRideElementProperty != null && overRideElementProperty.PropertyType == baseRendererElementProperty.PropertyType)
                    //{
                    //    rendererType = overRideRendererType;

                    //}

                    Xamarin.Forms.Internals.Registrar.Registered.Register(baseRendererElementProperty.PropertyType, rendererType, new[] { typeof(CustomVisual) });
                    if (overRideElementProperty != null && overRideElementProperty.PropertyType == baseRendererElementProperty.PropertyType)
                    {
                        Xamarin.Forms.Internals.Registrar.Registered.Register(baseRendererElementProperty.PropertyType, overRideRendererType, new[] { typeof(CustomVisual) });

                    }



                    //Xamarin.Forms.Internals.




                    Debug.WriteLine("============================================================");

                }

            }
            Debug.WriteLine($"Finished registering CustomRenderers");





            //foreach (var formsType in formsAssembly.DefinedTypes)
            //{
            //    Debug.WriteLine($"formsType: {formsType.AssemblyQualifiedName}");
            //    if (formsType.Name.Contains("Registrar") )
            //    {
            //        Debug.WriteLine($"Registrar found public: {formsType.IsPublic}");
            //        var ns = formsType.Namespace;
            //        var isPublic = formsType.IsPublic;
                    
            //        var methods = formsType.GetMethods();
            //        var staticMethods = formsType.GetMethods(BindingFlags.Static);
            //        //var method = formsType.GetMethod("RegisterRenderers");
            //        foreach (var method in methods)
            //        {
            //            Debug.WriteLine($"found the method {method.Name} static: {method.IsStatic}");

            //            if (method.Name == "RegisterAll")
            //            {
            //                var parameters = method.GetParameters();
            //                foreach (var parameter in parameters)
            //                {
            //                    Debug.WriteLine(parameter.Name);
            //                }
            //                Debug.WriteLine($"Is this it? {method}");

            //                //Type[] types
            //                //method.Invoke(null, rendererExports.ToArray());
            //            }

            //            if (method.IsStatic)
            //            {
            //                var parameters = method.GetParameters();
            //                foreach (var parameter in parameters)
            //                {
            //                    Debug.WriteLine($"parameter.Name");
            //                }
            //                Debug.WriteLine($"Is this it? {method}");
            //            }

            //        }
            //        Registrar.RegisterRenderers();


            //    }
            //}

            //Debug.WriteLine($"export? {export.ShouldRegister()}");
            //PlatformAssembly.e
        }

    }


}
