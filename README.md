# libphonenumber-csharp

Cloned from [https://bitbucket.org/pmezard/libphonenumber-csharp](https://bitbucket.org/pmezard/libphonenumber-csharp) branch 'csharp'

> C# port of Google's libphonenumber library (checkout "csharp" branch).


# libphonenumber

[https://code.google.com/p/libphonenumber/](https://code.google.com/p/libphonenumber/)

> Google's common Java, C++ and Javascript library for parsing, formatting, storing and validating international phone numbers. The Java version is optimized for running on smartphones, and is used by the Android framework since 4.0 (Ice Cream Sandwich).

# branches

## master

Clone of libphonenumber-csharp branch 'csharp'

## shortcode_support

libphonenumber currently officially does not support shortcodes.

The feature is in the works, however:

> From: Shaopeng <jia.shao.p...@gmail.com>
> To: "libphonenumber-discuss@googlegroups.com" <libphonenumber-discuss@googlegroups.com>
> 
> Hello Martin,
> 
> It is our plan to build utilities to parse, validate, and type short codes
> once we have a reasonable collection of short code metadata. We hope to
> start that work some time next quarter.
> 
> Cheers,
> 
> Shaopeng

(Source: [https://groups.google.com/d/msg/libphonenumber-discuss/Fm4kN-TmxSQ/sOLODFRyO5QJ](https://groups.google.com/d/msg/libphonenumber-discuss/Fm4kN-TmxSQ/sOLODFRyO5QJ))

This branch adds shortcode support, until there is an official implementation.

References:

* [https://groups.google.com/forum/?fromgroups=#!topic/libphonenumber-discuss/Fm4kN-TmxSQ](https://groups.google.com/forum/?fromgroups=#!topic/libphonenumber-discuss/Fm4kN-TmxSQ)

# To Do

* Add support for shortcodes
* Update libphonenumber-csharp (currently at r515) with latest libphonenumber release (v5.4 r561)