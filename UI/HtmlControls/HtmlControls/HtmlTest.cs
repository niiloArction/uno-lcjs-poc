using System;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using Uno.UI.Runtime.WebAssembly;

namespace HtmlControls
{
    [HtmlElement("iframe")]
    public partial class HtmlTest : FrameworkElement
    {
        public HtmlTest()
        {
            // Set a background to ensure pointer events are allowed
            Background = new SolidColorBrush(Colors.Transparent);

            // NOTE: Concern "style.css" is currently loaded from HtmlControls.Wasm/WasmCSS/style.css. I believe this is not bundled in Control Library, but kind of in users project directory. This CSS should be part of control library though?
            this.SetCssClass("test");

            // NOTE: Test for showing static URL. Doesn't seem to work?
            this.SetHtmlAttribute("src", "https://lightningchart.com/lightningchart-js-interactive-examples/");

            // TODO: Not able to load HTML asset (HtmlControls/Assets/test.html) to iframe src.
            //this.SetHtmlAttribute("src", "ms-appx:///HtmlControls/Assets/test.html");
            //this.SetHtmlAttribute("src", "ms-appx:///htmlcontrols/Assets/test.html");
            //this.SetHtmlAttribute("src", "ms-appx:///htmlcontrols/test.html");
            //this.SetHtmlAttribute("src", "ms-appx:///test.html");
            Uri uri = new Uri("ms-appx:///HtmlControls/Assets/test.html");
            Console.WriteLine(uri.ToString());
            this.SetHtmlAttribute("src", uri.ToString());
        }
    }
}
