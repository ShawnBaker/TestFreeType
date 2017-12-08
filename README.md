# TestFreeType

This app tests linking FreeType in a C# app for iOS using Visual Studio.

It uses the included **build_freetype.sh** script to download the latest FreeType and build a fat library
containing the following architectures:

- armv7
- armv7s
- x86_64
- arm64

It includes the **libfreetype.a** file in the project according to the instructions on this Xamarin page:

   https://developer.xamarin.com/guides/ios/advanced_topics/native_interop/

The app builds and runs but fails with an **System.EntryPointNotFoundException** error when trying to call **FT_Init_FreeType**.
