using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using ServiceStack;
using System.Collections.Generic;
using ServiceStack.Text;
using System.Net;
using System.IO;

namespace CovingtonStockWatch
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            Uri uriAddress = new Uri("http://download.finance.yahoo.com/d/quotes.csv?s=MCI+DIS+COKE+PEP&f=sl1d1t1c1");
            string result;
            // Make a WebClient.
            WebClient web_client = new WebClient();

            try
            {
                // Get the indicated URL.
                Stream response = web_client.OpenRead(uriAddress.AbsoluteUri.ToString());

                // Read the result.
                using (StreamReader stream_reader = new StreamReader(response))
                {
                    // Get the results.
                    result = stream_reader.ReadToEnd();

                    // Close the stream reader and its underlying stream.
                    stream_reader.Close();

                    // Return the result.



                }

                string[] lines = result.Split(
                    new char[] { '\r', '\n' },
                    StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(decimal.Parse(lines[0].Split(',')[1]).ToString("C3"));
                Console.WriteLine(decimal.Parse(lines[1].Split(',')[1]).ToString("C3"));
                Console.WriteLine(decimal.Parse(lines[2].Split(',')[1]).ToString("C3"));
                Console.WriteLine(decimal.Parse(lines[3].Split(',')[1]).ToString("C3"));

            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);


        }

       

    }
}