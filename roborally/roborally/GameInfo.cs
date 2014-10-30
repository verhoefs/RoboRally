
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
	[Activity (Label = "GameInfo")]			
	public class GameInfo : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.GameInfo);

			ImageView imgview = FindViewById<ImageView>(Resource.Id.imageView1);
			ImageView patch = FindViewById<ImageView>(Resource.Id.imageView2);
			TextView txtview = FindViewById<TextView> (Resource.Id.textView1);
			Button button = FindViewById<Button> (Resource.Id.button1);


			imgview.SetImageResource(Resource.Drawable.robot);
			patch.SetImageResource (Resource.Drawable.eyepatch);
			patch.Visibility = ViewStates.Invisible;
			txtview.Text = "Versie_1.1" +
			" 10.11.2014" +
			" "+
			" Casus_PIT1" +
			" Groep_4 " +
			" "+
			" Made_by:" +
			" Diewe_van_Geffen" +
			" Rik_Kierkels" +
			" Dennis_Verhoeven" +
			" Falco_Rijnierkens" +
			" Angelo_Brouns" +
			" Guido_Theelen";

			button.Click += delegate {

				patch.Visibility = ViewStates.Visible;
				StartActivity (typeof(SpelMenu));
			};
				
			}

	}

		
}


