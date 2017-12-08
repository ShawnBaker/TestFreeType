using System;
using System.Runtime.InteropServices;
using UIKit;

namespace TestFreeType
{
    public partial class ViewController : UIViewController
    {
        [DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
        public static extern int FT_Init_FreeType(out IntPtr library);

        protected ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            IntPtr lib;
            int result = FT_Init_FreeType(out lib);
        }
    }
}
