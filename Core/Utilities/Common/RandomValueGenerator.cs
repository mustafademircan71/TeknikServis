using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Common
{
    public static class RandomValueGenerator
    {
        public static string GeneratePassword(int length)
        {
            return Guid.NewGuid()
                       .ToString()
                       .Replace("-", "")
                       .Substring(0, length);
        }

        public static string GenerateFileName(string extension)
        {
            return Guid.NewGuid()
                       .ToString()
                       .Replace("-", "") + extension;
        }
        public static string GenerateServiceCode(int serviceCode)
        {
            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, serviceCode);
        }
    }
}
