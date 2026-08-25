using System;
using System.Collections.Generic;
using Java.Util;

namespace Com.Braze
{
    /// <summary>
    /// Copies a Java/Kotlin <see cref="IMap"/> of string keys/values into a managed dictionary.
    /// </summary>
    /// <remarks>
    /// Avoids <see cref="System.InvalidCastException"/> from
    /// <c>JavaDictionary&lt;string, string&gt;.FromJniHandle</c> when the native map is a
    /// Kotlin <c>emptyMap()</c> or <c>LinkedHashMap</c> rather than <c>java.util.HashMap</c>.
    /// </remarks>
    internal static class BrazeJavaStringMap
    {
        /// <summary>
        /// Copies map entries into a new managed <see cref="Dictionary{TKey, TValue}"/>.
        /// </summary>
        /// <param name="map">Native string map, or null. Caller retains ownership and must dispose.</param>
        /// <returns>Managed dictionary; never null.</returns>
        internal static IDictionary<string, string> CopyToDictionary(IMap? map)
        {
            var result = new Dictionary<string, string>();
            if (map == null)
            {
                return result;
            }

            var keySet = map.KeySet();
            if (keySet == null)
            {
                return result;
            }

            try
            {
                foreach (var keyObject in keySet)
                {
                    if (keyObject == null)
                    {
                        continue;
                    }

                    var key = keyObject.ToString();
                    if (key == null)
                    {
                        continue;
                    }

                    var javaKey = keyObject as Java.Lang.Object;
                    if (javaKey == null)
                    {
                        continue;
                    }

                    var valueObject = map.Get(javaKey);
                    try
                    {
                        result[key] = valueObject?.ToString() ?? string.Empty;
                    }
                    finally
                    {
                        valueObject?.Dispose();
                    }
                }
            }
            finally
            {
                (keySet as IDisposable)?.Dispose();
            }

            return result;
        }
    }
}
