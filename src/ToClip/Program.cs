using System.Globalization;
using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;
using TextCopy;
using ToClip.Config;

const string CFG = "toclip.mappings.json";

string key = args.FirstOrDefault() ?? throw new ArgumentException("missing required argument <id>.");

using Stream stream = File.OpenRead(Path.Combine(AppContext.BaseDirectory, CFG));
ConfigRoot config = JsonSerializer.Deserialize<ConfigRoot>(stream) ?? throw new FormatException("failed to deserialize config file!");

Mapping mapping = config.Mappings.Where(m => m.Id.Equals(key, StringComparison.InvariantCultureIgnoreCase)).SingleOrDefault() 
    ?? throw new KeyNotFoundException($"The specified Id '{key}' does not exist in '{CFG}'");

string value;
if (mapping.IsCodePoint)
{
    if (!Regex.IsMatch(mapping.Value, @"^U\+[a-fA-F0-9]+$"))
    {
        throw new FormatException($"Specified code point '{mapping.Value}' is invalid.");
    }
    int codepoint = int.Parse(mapping.Value[2..], NumberStyles.HexNumber);
    value = char.ConvertFromUtf32(codepoint);
}
else
{
    value = mapping.Value;
}

ClipboardService.SetText(value);