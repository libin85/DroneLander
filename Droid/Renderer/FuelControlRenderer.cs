using Android.Graphics;
using DroneLander.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.ProgressBar), typeof(FuelControlRenderer))]
namespace DroneLander.Droid.Renderer
{
    public class FuelControlRenderer: ProgressBarRenderer
    {
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ProgressBar> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.ScaleY = 4.0f;
				Control.ProgressDrawable.SetColorFilter(Android.Graphics.Color.Rgb(217, 0, 0), PorterDuff.Mode.SrcIn);
			}
		}
    }
}
