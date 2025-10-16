# NuGet Alternatives to SunamoToUnixLineEnding

This document lists popular NuGet packages that provide similar functionality to SunamoToUnixLineEnding.

## Overview

Line ending conversion utilities

## Alternative Packages

### System.String.Replace
- **NuGet**: System.Runtime
- **Purpose**: Built-in replacement
- **Key Features**: Replace("\r\n", "\n")

### System.Text.RegularExpressions
- **NuGet**: System.Text.RegularExpressions
- **Purpose**: Pattern-based conversion
- **Key Features**: Regex.Replace for line endings

### EditorConfig
- **NuGet**: EditorConfig.Core
- **Purpose**: Editor configuration
- **Key Features**: Configure line endings per file type

## Comparison Notes

Simple string replacement handles line ending conversion. EditorConfig for standardization.

## Choosing an Alternative

Consider these alternatives based on your specific needs:
- **System.String.Replace**: Built-in replacement
- **System.Text.RegularExpressions**: Pattern-based conversion
- **EditorConfig**: Editor configuration
