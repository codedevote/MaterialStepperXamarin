using Android.Content;
using Android.Runtime;
using Android.Support.V4.App;
using System;
using System.Linq;
using Com.Stepstone.Stepper;
using Com.Stepstone.Stepper.Adapter;
using Android.OS;

namespace MaterialStepperXamarinSample
{
    public class StepperAdapter : AbstractFragmentStepAdapter
    {
        public StepperAdapter(FragmentManager p0, Context p1) : base(p0, p1)
        {

        }

        public override int Count => 3;

        public override IStep CreateStep(int position)
        {
            var step = new StepFragment(position);
            Bundle b = new Bundle();
            b.PutInt("position", position);
            step.Arguments = b;
            return step;
        }
    }
}