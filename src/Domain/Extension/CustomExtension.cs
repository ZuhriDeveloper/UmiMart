using System;


namespace UMApplication.Domain.Extension
{
    public static class CustomExtension
    {
        public static string ToDateString(this DateTime? dt, string format)
    => dt == null ? "n/a" : ((DateTime)dt).ToString(format);
    }
}
