using Android.App;
using Android.Widget;
using Android.OS;
using Com.Stepstone.Stepper;
using Android.Support.V7.App;

namespace MaterialStepperXamarinSample
{
    [Activity(Label = "MaterialStepperXamarinSample", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private StepperLayout _stepper;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _stepper = FindViewById<StepperLayout>(Resource.Id.stepperLayout);
            _stepper.Adapter = new StepperAdapter(SupportFragmentManager, this);

        }
    }
}

