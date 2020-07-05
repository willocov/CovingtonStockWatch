using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Webkit;
using Android.Widget;
using System;

namespace CovingtonStockWatch
{
    [Activity(Label = "Covington Stock Watch", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        WebView mainWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            //Set webview parameters
            try
            {
                mainWebView = FindViewById<WebView>(Resource.Id.webView1);
                mainWebView.SetWebViewClient(new WebViewClient());
                mainWebView.Settings.JavaScriptEnabled = true;
                mainWebView.LoadUrl("file:///android_asset/StockWatchUI/index.html");
            }
            catch (Exception ex) {
                Android.Support.V7.App.AlertDialog.Builder builder = new Android.Support.V7.App.AlertDialog.Builder(this);
                builder.SetTitle("Error");
                TextView input = new TextView(this);
                input.SetPadding(10, 2, 2, 2);
                input.Text = "Failed to Load Application Webview: " + ex.Message;
                builder.SetView(input);

                builder.Create().Show();
            }

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);


        }

       

    }
}