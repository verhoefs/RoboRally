
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
			ImageButton imgbutton1 = FindViewById<ImageButton> (Resource.Id.imageButton1);
			ImageButton imgbutton2 = FindViewById<ImageButton> (Resource.Id.imageButton2);
			ImageButton imgbutton3 = FindViewById<ImageButton> (Resource.Id.imageButton3);
			ImageButton imgbutton4 = FindViewById<ImageButton> (Resource.Id.imageButton4);
			ImageButton imgbutton5 = FindViewById<ImageButton> (Resource.Id.imageButton5);


			imgview.SetImageResource (Resource.Drawable.robotmenu);
			imgbutton1.SetImageResource (Resource.Drawable.Bnewgame);
			imgbutton2.SetImageResource (Resource.Drawable.BVrienden);
			imgbutton3.SetImageResource (Resource.Drawable.Bscores);
			imgbutton4.SetImageResource (Resource.Drawable.Btoeschouwer);
			imgbutton5.SetImageResource (Resource.Drawable.Bgameinfo);



			imgbutton1.Click += delegate { 

				StartActivity(typeof(NieuwSpelMenu));
			};

			imgbutton2.Click += delegate { 

				StartActivity(typeof(MenuVrienden));
			};

			imgbutton3.Click += delegate { 

				StartActivity(typeof(MenuToeschouwer));
			};

			imgbutton4.Click += delegate { 

				StartActivity(typeof(MenuScores));
			};

			imgbutton5.Click += delegate { 

				StartActivity(typeof(GameInfo));
			};
		}
	}
}

