
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
using Android.Graphics;

namespace roborally
{
	[Activity (Label = "NieuwSpelMenu")]			
	public class NieuwSpelMenu : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			 
			SetContentView (Resource.Layout.NieuwSpelMenu);

			ImageView imageV = FindViewById<ImageView> (Resource.Id.imageView1);
			ImageButton imgbutton1 = FindViewById<ImageButton> (Resource.Id.imageButton1);
			ImageButton imgbutton2 = FindViewById<ImageButton> (Resource.Id.imageButton2);
			Button button = FindViewById<Button> (Resource.Id.button1);

			imageV.SetImageResource (Resource.Drawable.newgame);
			imgbutton1.SetImageResource (Resource.Drawable.singleplayer);
			imgbutton2.SetImageResource (Resource.Drawable.onlineaGame);
			button.SetBackgroundColor (Color.DarkOrange);
			button.SetTextColor (Color.Black);

			button.Click += delegate 
			{
				button.SetBackgroundColor (Color.Blue);
				StartActivity(typeof(SpelMenu));
			};
		}
	}
}
				 
