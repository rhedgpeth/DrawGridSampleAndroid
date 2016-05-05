using Android.App;
using Android.Widget;
using Android.OS;

namespace DrawGridSample
{
	[Activity(Label = "DrawGridSample", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			GridView gv = new GridView(this);

			SetContentView(gv);
		}
	}
}


