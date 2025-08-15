
# SplashIconGenerator

A simple .NET 8 console app to generate multiple icon sizes from a source PNG folder.

## Features
- Reads all `.png` files from `/icons`
- Generates multiple resolutions: 256x256, 512x512, 1024x1024
- Saves results in `/output/{resolution}` subfolders
- Keeps original icons untouched

## Usage
```bash
dotnet build
dotnet run
```

## Notes
- Replace images in `/icons` with your own assets.
- Output icons will appear in `/output` without overwriting originals.
