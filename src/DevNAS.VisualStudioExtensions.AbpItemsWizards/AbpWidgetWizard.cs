using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevNAS.VisualStudioExtensions.AbpItemsWizards
{
    public class AbpWidgetWizard : IWizard
    {
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
                ShowUserInputForm(replacementsDictionary);
            }
            catch (WizardCancelledException)
            {
                // Throw a new exception to signal that the wizard has been cancelled.
                // This will prevent the item from being added to the project.
                throw new WizardBackoutException("User cancelled the wizard.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ShowUserInputForm(Dictionary<string, string> replacementsDictionary)
        {
            // Init Item Context and UserFormInput
            var itemContext = ItemContext.FromReplacementsDictionary(replacementsDictionary);
            var inputForm = new UserInputForm(itemContext);

            // show & handle user input
            if (inputForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                replacementsDictionary["$safeitemname$"] = inputForm.WidgetName;
                replacementsDictionary["$WidgetName$"] = inputForm.WidgetName;
                replacementsDictionary["$RefreshUrl$"] = inputForm.RefreshUrl;
                replacementsDictionary["$ViewRootPath$"] = inputForm.ViewDirectoryPath;
                replacementsDictionary["$ViewPath$"] = inputForm.ViewPath;
            }
            else
            {
                throw new WizardCancelledException("User cancelled the wizard.");
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
