using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using Uno.Extensions;
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

            //this.SetHtmlAttribute("type", "time");
            //this.SetCssStyle("height", "500px");
            this.SetCssClass("test");
            this.SetHtmlAttribute("src", "https://lightningchart.com/lightningchart-js-interactive-examples/");

            // TODO: CSS Asset in Control Library not loaded on page. Probably we need to load it from Asset and apply it with executed JS.

            // NOTE: Concern, HtmlTest belongs to a Control Library. Currently it is referencing assets outside the library.
            //this.SetHtmlAttribute("src", "ms-appx:///HtmlControls/Assets/test.html");
            //this.SetHtmlAttribute("src", "ms-appx:///htmlcontrols/Assets/test.html");

            //this.SetHtmlAttribute("src", "ms-appx:///htmlcontrols/test.html");

            //this.SetHtmlAttribute("src", "ms-appx:///test.html");

            Uri uri = new Uri("ms-appx:///HtmlControls/Assets/test.html");
            Console.WriteLine(uri.ToString());
            this.SetHtmlAttribute("src", uri.ToString());

            //this.SetHtmlContent("Hello hello");

            //this.ExecuteJavascript("element.addEventListener(\"change\", ()=>element.dispatchEvent(new CustomEvent(\"value\", {detail: element.value})));");
            //this.RegisterHtmlCustomEventHandler("value", OnHtmlValueChanged);
        }

        //private static readonly string[] _timeFormats = { "hh\\:mm", "hh\\:mm\\:ss" };

        //private void OnHtmlValueChanged(object sender, HtmlCustomEventArgs e)
        //{
        //    if (TimeSpan.TryParseExact(e.Detail, _timeFormats, DateTimeFormatInfo.InvariantInfo, TimeSpanStyles.None, out var time))
        //    {
        //        Time = time;
        //    }
        //    else
        //    {
        //        Console.Error.WriteLine($"Unable to parse {e.Detail} as a valid Time.");
        //    }
        //}

        //public static readonly DependencyProperty TimeProperty = DependencyProperty.Register(
        //    "Time", typeof(TimeSpan), typeof(HtmlTest), new PropertyMetadata(default(TimeSpan), propertyChangedCallback: OnTimeChanged));

        //public TimeSpan Time
        //{
        //    get => (TimeSpan)GetValue(TimeProperty);
        //    set => SetValue(TimeProperty, value);
        //}

        //private static void OnTimeChanged(DependencyObject o, DependencyPropertyChangedEventArgs args)
        //{
        //    if (o is HtmlTest picker && args.NewValue is TimeSpan time)
        //    {
        //        var value = time.ToString("hh\\:mm\\:ss", DateTimeFormatInfo.InvariantInfo);
        //        picker.ExecuteJavascript($"element.value=\"{value}\";");
        //    }
        //}

        //protected override Size MeasureOverride(Size availableSize)
        //{
        //    // Delegate measurement to Html <input> element
        //    return this.MeasureHtmlView(availableSize, false);
        //}
    }
}
