namespace Haley.Enums {
    public enum ThemeReplaceMode {
        /// <summary>
        /// Searches each of the resource dictionary to find a matching theme and replaces it. If a root's merged dictionary contains a match, it will also be replaced.
        /// </summary>
        FindReplace,
        /// <summary>
        /// Apart from finding and replacing, this will ALSO create a new copy at root.
        /// </summary>
        FindReplaceAndCreateCopy,
        /// <summary>
        /// Findandreplace method will be ignored. Straight away we create copies at root.
        /// </summary>
        IgnoreFindReplaceAndCreateCopy
    }
}
