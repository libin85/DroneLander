using System;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V4.Content;
using DroneLander.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Slider), typeof(ThrottleControlRenderer))]
namespace DroneLander.Droid.Renderer
{
    public class ThrottleControlRenderer : SliderRenderer
    {
		protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.ProgressDrawable.SetColorFilter(Android.Graphics.Color.Rgb(217, 0, 0), PorterDuff.Mode.SrcIn);
				Drawable myThumb = ContextCompat.GetDrawable(Context, Resource.Drawable.throttle_thumb);
				Control.SetThumb(myThumb);
			}
		}
    }
}
