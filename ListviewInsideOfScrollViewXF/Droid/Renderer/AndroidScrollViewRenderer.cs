using System;
using Android.Views;
using ListviewInsideOfScrollViewXF;
using ListviewInsideOfScrollViewXF.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AndroidScrollViewRender), typeof(AndroidScrollViewRenderer))]
namespace ListviewInsideOfScrollViewXF.Droid
{
	public class AndroidScrollViewRenderer:ScrollViewRenderer
	{
		float StartX, StartY;
		int ScrollIsHorizontal = -1;

		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);
			if (((ScrollView)e.NewElement).Orientation == ScrollOrientation.Horizontal) ScrollIsHorizontal = 1;

		}

		public override bool DispatchTouchEvent(MotionEvent e)
		{

			switch (e.Action)
			{
				case MotionEventActions.Down:
					StartX = e.RawX;
					StartY = e.RawY;
					this.Parent.RequestDisallowInterceptTouchEvent(true);
					break;
				case MotionEventActions.Move:
					if (ScrollIsHorizontal * Math.Abs(StartX - e.RawX) < ScrollIsHorizontal * Math.Abs(StartY - e.RawY))
						this.Parent.RequestDisallowInterceptTouchEvent(false);
					break;
				case MotionEventActions.Up:
					this.Parent.RequestDisallowInterceptTouchEvent(false);
					break;
			}

			return base.DispatchTouchEvent(e);
		}

	}
}
