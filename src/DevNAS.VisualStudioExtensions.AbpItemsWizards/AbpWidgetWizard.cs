using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevNAS.VisualStudioExtensions.AbpItemsWizards
{
    public class AbpWidgetWizard : IWizard
    {
        private UserInputForm inputForm;

        // This method is called before opening any item that
        // has the OpenInEditor attribute.
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        // This method is only called for item templates,
        // not for project templates.
        public void ProjectItemFinishedGenerating(ProjectItem
            projectItem)
        {
        }

        // This method is called after the project is created.
        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject,
            Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            try
            {
                // Display a form to the user. The form collects
                string defaultNamespace = replacementsDictionary["$defaultnamespace$"];
                string rootNamespace = replacementsDictionary["$rootnamespace$"];
                string relativeNamespace = rootNamespace.Replace($"{defaultNamespace}.", "");
                string relarivePath = "/" + relativeNamespace.Replace(".", "/");
                string safeItemName = replacementsDictionary["$safeitemname$"];

                // set initial values
                string all = String.Join("<>", new string[] {
                    replacementsDictionary["$solutiondirectory$"],
                    replacementsDictionary["$rootname$"],
                    replacementsDictionary["$safeitemname$"],
                    replacementsDictionary["$rootnamespace$"],
                    replacementsDictionary["$defaultnamespace$"]
                });

                inputForm = new UserInputForm();
                inputForm.WidgetName = replacementsDictionary["$safeitemname$"];
                inputForm.RefreshUrl = $"{relarivePath}/{safeItemName}";
                inputForm.ViewPath = $"{relarivePath}/{safeItemName}ViewComponent.cshtml";
                inputForm.DebugTxt = all;
                // handle user input
                if (inputForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    replacementsDictionary["$safeitemname$"] = inputForm.WidgetName;
                    replacementsDictionary["$WidgetName$"] = inputForm.WidgetName;
                    replacementsDictionary["$RefreshUrl$"] = inputForm.RefreshUrl;
                    replacementsDictionary["$ViewPath$"] = inputForm.ViewPath;
                }
                else
                {
                    throw new WizardCancelledException("User cancelled the wizard.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // This method is only called for item templates,
        // not for project templates.
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
