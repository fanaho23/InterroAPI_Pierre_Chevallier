using Android.App;
using Android.Widget;
using Android.OS;

namespace InterroAPI
{
    [Activity(Label = "InterroAPI", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Toast.MakeText(this, "hello", ToastLength.Long).Show();
        }
    }
}

