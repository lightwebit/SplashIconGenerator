SplashIconGenerator

A .NET console utility that generates application splash and icon images in multiple resolutions from a single source image.
It supports adaptive cropping or letterbox fitting and keeps original files intact by saving generated assets into an output folder.

Features

Generate icons in multiple resolutions automatically.

Optional centered adaptive crop or fit with letterbox.

Keeps original input images untouched.

Works cross-platform (Windows, macOS, Linux) via .NET.

Dummy icons included for testing.

Requirements

.NET 8 SDK or newer (you can later upgrade to .NET 9).

An image file (.png, .jpg, .jpeg) to use as the source.

Basic terminal/command prompt knowledge.

Build & Run Locally
1. Clone the Repository
git clone https://github.com/YOUR-USERNAME/SplashIconGenerator.git
cd SplashIconGenerator

2. Restore Dependencies
dotnet restore

3. Build
dotnet build

4. Run with Example
dotnet run --project SplashIconGenerator.csproj --     --input "./dummy-icons/source.png"     --output "./output"     --adaptiveCrop true

Command-Line Arguments
Argument	Description	Example
--input	Path to the source image (PNG or JPG).	--input "./images/logo.png"
--output	Destination folder where generated icons will be stored.	--output "./output"
--adaptiveCrop	true = centered crop, false = fit with letterbox. Optional. Default: false.	--adaptiveCrop true
Example Usage
dotnet run --project SplashIconGenerator.csproj --     --input "./dummy-icons/logo.png"     --output "./output"     --adaptiveCrop false


The generated files will appear in the output directory in multiple resolutions, ready for app store submission or packaging.

Testing with Dummy Icons

A couple of sample images are included in dummy-icons/ so you can test the generator without your own files.

Example:

dotnet run --project SplashIconGenerator.csproj --     --input "./dummy-icons/test.png"     --output "./output"

License

MIT License – free to use and modify for personal or commercial projects.
