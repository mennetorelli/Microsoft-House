﻿using System;
using Android.Graphics;
using MicrosoftHouse;
using MicrosoftHouse.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtendedPicker), typeof(ExtendedPickerRender))]
namespace MicrosoftHouse.Droid
{
	public class ExtendedPickerRender : PickerRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
		{
			base.OnElementChanged(e);

			ExtendedPicker picker = (ExtendedPicker)Element;

			if (picker != null)
			{
				//Control.SetBackgroundColor(Android.Graphics.Color.White);
				Control.TextSize = 14f;

				/*var shape = new ShapeDrawable(new RectShape());
				shape.Paint.Alpha = 0;
				shape.Paint.SetStyle(Paint.Style.Stroke);
				Control.SetBackgroundDrawable(shape);*/

				//Border
				Control.Background.SetAlpha(10);
				Control.Background.SetColorFilter(Android.Graphics.Color.Black, PorterDuff.Mode.SrcAtop);

				//Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Avenir");  // font name specified here
				//Control.Typeface = font;
				//Control.Typeface =
				//Control.FontFeatureSettings = 
				//Control.BorderStyle = UITextBorderStyle.None;
				//Control.Font = UIFont.FromName("Avenir", 14f);
				SetPlaceholder(picker);
				SetTextColor(picker);
				//SetFont(datePicker);

			}

			if (e.OldElement == null)
			{
				//Wire events
			}

			if (e.NewElement == null)
			{
				//Unwire events
			}
		}

		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (Control == null)
			{
				return;
			}

			ExtendedPicker picker = (ExtendedPicker)Element;

			if (e.PropertyName == ExtendedPicker.TextColorProperty.PropertyName)
			{
				SetTextColor(picker);
			}
		}

		void SetTextColor(ExtendedPicker picker)
		{
			this.Control.SetTextColor(picker.TextColor.ToAndroid());
		}

		void SetPlaceholder(ExtendedPicker picker)
		{
			this.Control.Text = picker.PlaceHolder;
		}

		/*private void SetFont(ExtendedDatePicker datePicker)
		{
			if (datePicker.Font != Font.Default)
			{
				Control.TextSize = datePicker.Font.ToScaledPixel();
				//Control.Typeface = view.Font.ToExtendedTypeface(Context);
			}
			}*/
	}
}
