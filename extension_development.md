# Extension Development for ABP.io Items Generator

## Resources for Creating VSIX Templates

To get started with creating VSIX templates for Visual Studio, you can refer to the following resources:

1. [Creating Custom Project and Item Templates](https://learn.microsoft.com/en-us/visualstudio/extensibility/creating-custom-project-and-item-templates?view=vs-2022) - This guide provides an overview of how to create custom project and item templates in Visual Studio.
2. [How to Use Wizards with Project Templates](https://learn.microsoft.com/en-us/visualstudio/extensibility/how-to-use-wizards-with-project-templates?view=vs-2022) - This article explains how to use wizards to enhance the functionality of project templates.

### Note: Project Template vs Item Template
The referenced tutorials primarily focus on Project Templates, which are used to create entire projects with a specific structure and set of files. In contrast, our extension uses Item Templates, which are designed to add individual files or groups of files to an existing project.

While Project Templates and Item Templates serve different purposes, they share some aspects in customization and packaging for Visual Studio. Both types of templates can utilize wizards to gather input from the user and can be packaged as VSIX extensions for easy distribution and installation.

## Extension Structure

The ABP.io Widget Generator extension consists of the following projects:

### src\DevNAS.VisualStudioExtensions.AbpItemsGenerator

- **Project Type:** VSIX Project
- **Description:** This project contains the extension manifest (`source.extension.vsixmanifest`) and configuration files. It is responsible for defining the extension package and its metadata, such as the display name, description, and version.

### src\DevNAS.VisualStudioExtensions.AddWidgetTemplate

- **Project Type:** Item Template
- **Description:** This project contains the item template files and manifest (`AbpWidgetGenerator.vstemplate`) for the ABP.io Widget Generation. It defines the structure and content of the widget template, including the ViewComponent, Controller, and related files like CSS and JavaScript.

### src\DevNAS.VisualStudioExtensions.AbpItemsWizards

- **Project Type:** Windows Forms Class Library
- **Description:** This project contains the wizards for item templates. Wizards are used to customize the behavior of the template, such as gathering additional input from the user or performing custom actions when the template is instantiated.