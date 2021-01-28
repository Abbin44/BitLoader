using System;

namespace Torrent
{
    class MagnetLink
    {
        /*
         * This class is mostly copied from this project
         * https://github.com/hexafluoride/byteflood
         */

        public InfoHash InfoHash { get; private set; }
        public string Name { get; private set; }

        public MagnetLink(string url)
        {
            ParseMagnetLink(url);
        }

        void ParseMagnetLink(string url)
        {
            string[] splitString = url.Split('?'); // Cut away the magnet:? part
            if (splitString.Length == 0 || splitString[0] != "magnet:")
                return;

            if (splitString.Length == 1)
                return;//no parametter

            string[] parameters = splitString[1].Split('&', ';'); //&tr=udp specifies every parameter

            for (int i = 0; i < parameters.Length; i++)//Loop through all trackers
            {
                string[] keyval = parameters[i].Split('=');//Remove the tr= to only have the tracker link remaining
                if (keyval.Length != 2)
                    return;

                switch (keyval[0].Substring(0, 2))
                {
                    case "xt"://exact topic
                        if (InfoHash != null)
                            throw new FormatException("More than one infohash in magnet link is not allowed.");

                        string value = keyval[1].Substring(9);

                        switch (keyval[1].Substring(0, 9))
                        {
                            case "urn:sha1:"://base32 hash
                            case "urn:btih:":
                                if (value.Length == 32)
                                    InfoHash = InfoHash.FromBase32(value);
                                else if (value.Length == 40)
                                    InfoHash = InfoHash.FromHex(value);
                                else
                                    throw new FormatException("Infohash must be base32 or hex encoded.");
                                break;
                            default:
                                throw new FormatException("Infohash must be base32 or hex encoded.");
                        }
                        break;
                    case "dn"://display name
                        Name = System.Web.HttpUtility.UrlDecode(keyval[1]);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}