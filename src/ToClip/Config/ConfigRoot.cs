namespace ToClip.Config;

internal record ConfigRoot(Mapping[] Mappings);

internal record Mapping(string Id, string Value, bool IsCodePoint, string? Description)
{
    public bool IsValid => !string.IsNullOrWhiteSpace(Id) && !string.IsNullOrEmpty(Value);
}