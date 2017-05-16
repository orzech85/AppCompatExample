using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace AppCompatExample
{
	[Activity(Label = "AppCompatExample", MainLauncher = true)]
	public class MainActivity : BaseActivity
	{
		protected override int LayoutResource => Resource.Layout.Main;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
		}
	}
}

