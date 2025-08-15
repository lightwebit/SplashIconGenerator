# SplashIconGenerator

Generates splash icons from a source directory with random resolutions.

## Requirements
- .NET 9 SDK

## Usage
1. Place your source images in the `icons` folder.
2. Build the project:
   ```bash
   dotnet build
   ```
3. Run the project:
   ```bash
   dotnet run
   ```
4. Generated icons will appear in the `output` folder.

## Notes
- Random resolutions between 64x64 and 512x512.
- Keeps original files intact.
