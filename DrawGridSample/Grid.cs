
using System;
using Android.Views;
using Android.Content;
using Android.Runtime;
using Android.Graphics;

namespace DrawGridSample
{
	public class GridView : View
	{
		private readonly Paint gridPaint;
		private readonly Paint textPaint;

	    public GridView(Context context) : base(context)
		{
			SetBackgroundColor(Color.Transparent);

			gridPaint = new Paint();
			gridPaint.SetStyle(Paint.Style.Stroke);
			gridPaint.Color = Color.Blue;
			gridPaint.StrokeWidth = 1f;

			textPaint = new Paint();
			textPaint.SetStyle(Paint.Style.Stroke);
			textPaint.Color = Color.White;
			textPaint.StrokeWidth = 1f;
		}

	    public GridView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{ }

	    public override void Draw(Canvas canvas)
		{
			var width = Width;
			var height = Height;

	    	var rows = 30;
			var columns = 30;

	    	var rowSize = Math.Round((float)(height / rows));
			var colSize = Math.Round((float)(width / columns));

	    	for (int r = 1; r < rows; r++)
			{
				var y = (float)(r * rowSize);
				canvas.DrawLine(0f, y, width, y, gridPaint);
			}

	    	for (int c = 1; c < columns; c++)
			{
				var x = (float)(c * colSize);
				canvas.DrawLine(x, 0f, x, height, gridPaint);
			}

			int counter = 1;

			float cellY = (float)(rowSize / 2);

			for (int i = 0; i < 30; i++)
			{
				float cellX = (float)(colSize / 2);

				for (int k = 0; k < 30; k++)
				{
					canvas.DrawText(counter.ToString(), cellX, cellY, textPaint);

					cellX += (float)colSize;

					counter++;
				}

				cellY += (float)rowSize;
			}
		}
	}
}


