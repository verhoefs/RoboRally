using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace roborally
{
	[Activity (Label = "roborally", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			ImageView img1 = FindViewById<ImageView> (Resource.Id.imageView1);
			ImageView img2 = FindViewById<ImageView> (Resource.Id.imageView2);
			ImageButton imgbutton = FindViewById<ImageButton> (Resource.Id.imageButton1);
			Button inlogbutton = FindViewById<Button> (Resource.Id.button1);
			Button forgotpass = FindViewById<Button> (Resource.Id.button2);
			Button createaccount = FindViewById<Button> (Resource.Id.button3);
			EditText emailtext = FindViewById<EditText> (Resource.Id.editText1);

			// Link to pictures
			img1.SetImageResource (Resource.Drawable.background);
			img2.SetImageResource (Resource.Drawable.achtergrond2);
			imgbutton.SetImageResource (Resource.Drawable.facebook);

			inlogbutton.Click += delegate { 

				if (emailtext.Text != emailtext.Hint)
					StartActivity(typeof(SpelMenu));
				else 
					//emailtext.HintTextColors (Color.Red);
					emailtext.Hint = "Geef uw e-mail adres op!";
			};
		}
	}
}



