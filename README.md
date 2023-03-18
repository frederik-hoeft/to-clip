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

It is highly recommended to use this with PowerToys Run (with `toclip` in the PATH)
