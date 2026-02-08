using System;
using System.Globalization;
using System.Text;

namespace EraWheel.Narrative.AI.Providers
{
    internal static class JsonText
    {
        public static string Escape(string value)
        {
            if (string.IsNullOrEmpty(value)) return "";

            var sb = new StringBuilder(value.Length + 16);
            for (var i = 0; i < value.Length; i++)
            {
                var ch = value[i];
                switch (ch)
                {
                    case '\\': sb.Append("\\\\"); break;
                    case '"': sb.Append("\\\""); break;
                    case '\n': sb.Append("\\n"); break;
                    case '\r': sb.Append("\\r"); break;
                    case '\t': sb.Append("\\t"); break;
                    case '\b': sb.Append("\\b"); break;
                    case '\f': sb.Append("\\f"); break;
                    default:
                        if (ch < 32)
                        {
                            sb.Append("\\u");
                            sb.Append(((int)ch).ToString("X4", CultureInfo.InvariantCulture));
                        }
                        else
                        {
                            sb.Append(ch);
                        }
                        break;
                }
            }
            return sb.ToString();
        }

        public static bool TryExtractString(string json, string key, out string value)
        {
            return TryExtractStringAfter(json, key, 0, out value);
        }

        public static bool TryExtractStringAfter(string json, string key, int startIndex, out string value)
        {
            value = null;
            if (string.IsNullOrEmpty(json) || string.IsNullOrEmpty(key)) return false;

            var token = "\"" + key + "\"";
            var index = json.IndexOf(token, startIndex, StringComparison.Ordinal);
            if (index < 0) return false;
            index += token.Length;

            SkipWhitespace(json, ref index);
            if (index >= json.Length || json[index] != ':') return false;
            index++;
            SkipWhitespace(json, ref index);

            if (index >= json.Length || json[index] != '"') return false;
            index++;

            var sb = new StringBuilder();
            while (index < json.Length)
            {
                var ch = json[index++];
                if (ch == '"')
                {
                    value = sb.ToString();
                    return true;
                }

                if (ch == '\\' && index < json.Length)
                {
                    var esc = json[index++];
                    switch (esc)
                    {
                        case '"': sb.Append('"'); break;
                        case '\\': sb.Append('\\'); break;
                        case '/': sb.Append('/'); break;
                        case 'b': sb.Append('\b'); break;
                        case 'f': sb.Append('\f'); break;
                        case 'n': sb.Append('\n'); break;
                        case 'r': sb.Append('\r'); break;
                        case 't': sb.Append('\t'); break;
                        case 'u':
                            if (index + 4 <= json.Length)
                            {
                                var hex = json.Substring(index, 4);
                                if (int.TryParse(hex, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var code))
                                {
                                    sb.Append((char)code);
                                }
                                index += 4;
                            }
                            break;
                        default:
                            sb.Append(esc);
                            break;
                    }
                }
                else
                {
                    sb.Append(ch);
                }
            }

            return false;
        }

        public static bool TryExtractInt(string json, string key, out int value)
        {
            value = 0;
            if (string.IsNullOrEmpty(json) || string.IsNullOrEmpty(key)) return false;

            var token = "\"" + key + "\"";
            var index = json.IndexOf(token, StringComparison.Ordinal);
            if (index < 0) return false;
            index += token.Length;

            SkipWhitespace(json, ref index);
            if (index >= json.Length || json[index] != ':') return false;
            index++;
            SkipWhitespace(json, ref index);

            var start = index;
            while (index < json.Length)
            {
                var ch = json[index];
                if (!(char.IsDigit(ch) || ch == '-' || ch == '.'))
                    break;
                index++;
            }

            if (index <= start) return false;
            var num = json.Substring(start, index - start);
            if (double.TryParse(num, NumberStyles.Any, CultureInfo.InvariantCulture, out var parsed))
            {
                value = (int)Math.Round(parsed, MidpointRounding.AwayFromZero);
                return true;
            }

            return false;
        }

        private static void SkipWhitespace(string json, ref int index)
        {
            while (index < json.Length && char.IsWhiteSpace(json[index]))
            {
                index++;
            }
        }
    }
}
