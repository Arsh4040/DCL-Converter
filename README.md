# DCL Converter
A simple Windows tool to convert AutoCAD DCL dialog files into embedded AutoLISP code.
This app is designed to simplify AutoCAD tool distribution by packaging both .lsp and .dcl logic into a single .lsp file, eliminating the need to manage multiple files.

DCL files are still easier to write, edit, and maintain as separate files during development. This tool is not meant to replace that workflow, but to improve the final publishing step. Once development is complete, the DCL file can be packaged into the AutoLISP code, resulting in a single, self-contained .lsp file that is easier to share, install, and support.

## Features
- Converts .dcl files into embedded AutoLISP string definitions.
- Automatically generates a self-contained .lsp file.
- Removes the need to distribute separate .dcl files.
- Preserves DCL formatting while safely escaping strings.
- Ideal for publishing and sharing AutoCAD tools.
- Built with C# using Windows Forms.

## Screenshot
<img width="325" height="226" alt="image" src="https://github.com/user-attachments/assets/a5129cab-5c28-4ff5-8391-6bd2a22db91f" />


## Requirements
- Windows 10 or later
- .NET Framework (version compatible with WinForms app)
- AutoCAD (for running the generated .lsp files)

## Usage
The published application is located in the Application folder. You can download the Application folder and run the executable directly.
- Write and edit your dialog normally as a .dcl file.
- Open DCL Converter.
- Click Browse and select the .dcl file.
- Click Export.
- Choose a location to save the generated .lsp file.
- Load the .lsp file into AutoCAD and run the command.
