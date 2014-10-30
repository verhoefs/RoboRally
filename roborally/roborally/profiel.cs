
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
	[Activity (Label = "profiel")]			
	public class profiel : Activity
	{
		int getal = 0;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.profiel);

			ImageView img1 = FindViewById<ImageView> (Resource.Id.imageView1);
			ImageView img2 = FindViewById<ImageView> (Resource.Id.imageView2);
			TextView txt1 = FindViewById<TextView> (Resource.Id.textView1);
			Button but1 = FindViewById<Button> (Resource.Id.button1);
			Button but2 = FindViewById<Button> (Resource.Id.button2);
			Button but3 = FindViewById<Button> (Resource.Id.button3);
			EditText edtxt = FindViewById<EditText> (Resource.Id.editText1);
			EditText edtxt2 = FindViewById<EditText> (Resource.Id.editText2);
			EditText edtxt3 = FindViewById<EditText> (Resource.Id.editText3);


			img1.SetImageResource (Resource.Drawable.roboBackground);
			img2.SetImageResource (Resource.Drawable.LarryPage);


			but1.Click += delegate {
				if (getal % 2 == 0)
				{
					edtxt.Visibility = ViewStates.Gone;
					but1.Text = "Pas gebruikersnaam aan";
					txt1.Text = edtxt.Text;
					getal += 1
				}
				else
				{
					edtxt.Visibility = ViewStates.Visible;
					but1.Text = "Stel gebruikersnaam in";
					getal += 1
				}
				
			};

			but2.Click += delegate {
				edtxt2.Visibility = ViewStates.Visible;
				edtxt3.Visibility = ViewStates.Visible;
				but1.Text = "Stel wachtwoord in"

			};



		}
	}
}

