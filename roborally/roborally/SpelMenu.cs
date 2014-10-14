
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace roborally
{
	[Activity (Label = "SpelMenu")]			
	public class SpelMenu : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Menu);

			ImageView imgview = FindViewById<ImageView> (Resource.Id.imageView1);

			imgview.SetImageResource (Resource.Drawable.robotmenu);

			// Create your application here
		}
	}
}

