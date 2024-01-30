// Minimal SDWebImage interface for BrazeUI GIF support

using Foundation;
using ObjCRuntime;
using SDWebImage;
using UIKit;

namespace SDWebImage
{
    [BaseType (typeof(UIImage))]
    interface SDAnimatedImage
    {
        [Static]
        [Export ("imageWithContentsOfFile:")]
        [return: NullAllowed]
        SDAnimatedImage ImageWithContentsOfFile (string path);
    }

    [BaseType (typeof(UIImageView))]
    interface SDAnimatedImageView
    {
        [Export("initWithImage:")]
        NativeHandle Constructor(UIImage image);
    }
}
