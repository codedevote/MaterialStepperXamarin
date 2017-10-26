using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;
using Com.Stepstone.Stepper;

namespace MaterialStepperXamarinSample
{
    public class StepFragment : Fragment, IStep
    {
        private TextView _textview;

        public StepFragment(int step)
        {
            Step = step;
        }

        public int Step { get; }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            var view = inflater.Inflate(Resource.Layout.layout_step, container, false);

            _textview = view.FindViewById<TextView>(Resource.Id.textview);
            _textview.Text = $"Step {Step}";
            
            return view;
        }

        public void OnError(VerificationError p0)
        {

        }

        public void OnSelected()
        {

        }

        public VerificationError VerifyStep()
        {
            return null;    // null indicates no error
        }
    }
}