using System;
using System.Globalization;

namespace LeetCodeChallenges.JuneChallenge2020
{
    class Day16_ValidateIPAddress
    {
        public string ValidIPAddress(string IP)
        {
            if (IsIPV4(IP))
                return "IPv4";
            if (IsIPV6(IP))
                return "IPv6";
            return "Neither";
        }

        private bool IsIPV4(string ip)
        {
            var parts = ip.Split('.');

            if (parts.Length != 4)
                return false;

            foreach (var part in parts)
            {
                if (part.Length > 1 && part[0] == '0')
                    return false;

                if (!Int32.TryParse(part, NumberStyles.None, CultureInfo.InvariantCulture, out int partAsInt))
                    return false;
                if (partAsInt < 0 || partAsInt > 255)
                    return false;
            }
            return true;
        }

        private bool IsIPV6(string ip)
        {

            var parts = ip.Split(':');

            if (parts.Length != 8)
                return false;

            foreach (var part in parts)
            {
                if (part.Length < 1 || part.Length > 4)
                    return false;
                if (!Int32.TryParse(part, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int partAsInt))
                    return false;
            }
            return true;
        }
    }
}

