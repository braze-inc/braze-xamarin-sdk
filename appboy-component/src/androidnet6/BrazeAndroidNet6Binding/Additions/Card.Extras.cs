using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Util;

namespace Com.Braze.Models.Cards
{
    /// <summary>
    /// Content card binding additions.
    /// </summary>
    public partial class Card
    {
        static IntPtr _getExtrasMethodId;

        static void EnsureExtrasJni()
        {
            if (_getExtrasMethodId != IntPtr.Zero)
            {
                return;
            }

            var cardClassRef = JNIEnv.FindClass("com/braze/models/cards/Card");
            try
            {
                _getExtrasMethodId = JNIEnv.GetMethodID(cardClassRef, "getExtras", "()Ljava/util/Map;");
            }
            finally
            {
                JNIEnv.DeleteLocalRef(cardClassRef);
            }
        }

        /// <summary>
        /// Key-value extras for this card.
        /// </summary>
        /// <remarks>
        /// Returns a managed copy of the native extras map via JNI. Direct binding of
        /// <c>Map&lt;String, String&gt;</c> as <c>JavaDictionary&lt;string, string&gt;</c>
        /// throws <see cref="InvalidCastException"/> for Kotlin map runtimes
        /// (including empty extras).
        /// </remarks>
        public IDictionary<string, string> Extras
        {
            get
            {
                EnsureExtrasJni();
                var mapHandle = JNIEnv.CallObjectMethod(Handle, _getExtrasMethodId);
                var map = Java.Lang.Object.GetObject<IMap>(mapHandle, JniHandleOwnership.TransferLocalRef);
                try
                {
                    return BrazeJavaStringMap.CopyToDictionary(map);
                }
                finally
                {
                    map?.Dispose();
                }
            }
        }
    }
}
