# to-clip
Easily copy predefined values to your clipboard. Basically like keyboard macros, but for copying stuff to your clipboard instead.

---

## Usage

Assuming the defined mappings in `toclip.mappings.json` are:

```json
{
  "Mappings": [
    {
      "Id": "test",
      "Value": "it works :)",
      "IsCodePoint": false,
      "Description": "this is just a test"
    },
    {
      "Id": "test-code-point",
      "Value": "U+1D161",
      "IsCodePoint": true,
      "Description": "this is a unicode code point"
    }
  ]
}
```

Executing `toclip test` will put `"it works :)"` into your clipboard. Similarly `toclip test-code-point` will yield `𝅘𝅥𝅯`.

It is highly recommended to use this with PowerToys Run (with `toclip` in the PATH).

The `Description` in the `toclip.mappings.json` mappings is optional.

Another (more realistic) example for mappings:

```json
{
  "Mappings": [
    {
        "Id": "-zwsp",
        "Value": "U+200B",
        "IsCodePoint": true,
        "Description": "zero-width space"
    },
    {
        "Id": "-phi",
        "Value": "1.618033988749894",
        "IsCodePoint": false,
        "Description": "golden ratio for UI stuff"
    },
    {
        "Id": "-pi",
        "Value": "3.1415926536",
        "IsCodePoint": false
    },
    {
        "Id": "-ipsum",
        "Value": "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
        "IsCodePoint": false
    },
    {
        "Id": "-ipsum-short",
        "Value": "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
        "IsCodePoint": false
    }
  ]
}
```
