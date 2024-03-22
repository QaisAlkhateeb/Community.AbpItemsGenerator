using System.Collections.Generic;

namespace DevNAS.VisualStudioExtensions.AbpItemsWizards
{
    internal class ItemContext
    {
        public ItemContext(string solutionDirectory, string rootName, string safeitemName, string rootNamespace, string defaultNamespace)
        {
            SolutionDirectory = solutionDirectory;
            RootName = rootName;
            DefaultNamespace = defaultNamespace;
            SafeItemName = safeitemName;
            RootNamespace = rootNamespace;

            RelativeNamespace = rootNamespace.Replace($"{defaultNamespace}.", "");
            RelarivePath = "/" + RelativeNamespace.Replace(".", "/");
        }

        public string SolutionDirectory { get; private set; }
        public string RootName { get; private set; }
        public string DefaultNamespace { get; private set; }
        public string SafeItemName { get; private set; }
        public string RootNamespace { get; private set; }
        public string RelativeNamespace { get; private set; }
        public string RelarivePath { get; private set; }

        public static ItemContext FromReplacementsDictionary(Dictionary<string, string> replacementsDictionary)
        {
            return new ItemContext(replacementsDictionary["$solutiondirectory$"], replacementsDictionary["$rootname$"], replacementsDictionary["$safeitemname$"], replacementsDictionary["$rootnamespace$"], replacementsDictionary["$defaultnamespace$"]);
        }
    }
}
