using System;
using System.Reflection;

namespace TeleBotMessenger.Helper
{
    /// <summary>
    /// Gets the values from the AssemblyInfo.cs file for the current executing assembly
    /// </summary>
    /// <example>        
    /// string company = AssemblyInfo.Company;
    /// string product = AssemblyInfo.Product;
    /// string copyright = AssemblyInfo.Copyright;
    /// string trademark = AssemblyInfo.Trademark;
    /// string title = AssemblyInfo.Title;
    /// string description = AssemblyInfo.Description;
    /// string configuration = AssemblyInfo.Configuration;
    /// string fileversion = AssemblyInfo.FileVersion;
    /// Version version = AssemblyInfo.Version;
    /// string versionFull = AssemblyInfo.VersionFull;
    /// string versionMajor = AssemblyInfo.VersionMajor;
    /// string versionMinor = AssemblyInfo.VersionMinor;
    /// string versionBuild = AssemblyInfo.VersionBuild;
    /// string versionRevision = AssemblyInfo.VersionRevision;
    /// </example>
    public static class AssemblyInfo
    {
        public static string Company { get { return GetExecutingAssemblyAttribute<AssemblyCompanyAttribute>(a => a.Company); } }
        public static string Product { get { return GetExecutingAssemblyAttribute<AssemblyProductAttribute>(a => a.Product); } }
        public static string Copyright { get { return GetExecutingAssemblyAttribute<AssemblyCopyrightAttribute>(a => a.Copyright); } }
        public static string Trademark { get { return GetExecutingAssemblyAttribute<AssemblyTrademarkAttribute>(a => a.Trademark); } }
        public static string Title { get { return GetExecutingAssemblyAttribute<AssemblyTitleAttribute>(a => a.Title); } }
        public static string Description { get { return GetExecutingAssemblyAttribute<AssemblyDescriptionAttribute>(a => a.Description); } }
        public static string Configuration { get { return GetExecutingAssemblyAttribute<AssemblyDescriptionAttribute>(a => a.Description); } }
        public static string FileVersion { get { return GetExecutingAssemblyAttribute<AssemblyFileVersionAttribute>(a => a.Version); } }

        public static Version Version { get { return Assembly.GetExecutingAssembly().GetName().Version; } }
        public static string VersionFull { get { return Version.ToString(); } }
        public static string VersionMajor { get { return Version.Major.ToString(); } }
        public static string VersionMinor { get { return Version.Minor.ToString(); } }
        public static string VersionBuild { get { return Version.Build.ToString(); } }
        public static string VersionRevision { get { return Version.Revision.ToString(); } }

        private static string GetExecutingAssemblyAttribute<T>(Func<T, string> value) where T : Attribute
        {
            T attribute = (T)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(T));
            return value.Invoke(attribute);
        }
    }
}