using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyCompany("Region Örebro län")]
[assembly: AssemblyConfiguration(
#if DEBUG
	"Debug"
#else
	"Release"
#endif
	)]
#pragma warning disable 436

[assembly: AssemblyFileVersion(SolutionInfo.AssemblyVersion + ".0")]
[assembly: AssemblyInformationalVersion(SolutionInfo.AssemblyVersion + "-alpha")]
[assembly: AssemblyProduct(AssemblyInfo.AssemblyName)]
[assembly: AssemblyTitle(AssemblyInfo.AssemblyName)]
[assembly: AssemblyVersion(SolutionInfo.AssemblyVersion)]
#pragma warning restore 436

[assembly: ComVisible(false)]

internal static class SolutionInfo
{
	#region Fields

	internal const string AssemblyVersion = "0.0.1";

	#endregion
}