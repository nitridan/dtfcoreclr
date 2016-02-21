namespace Microsoft.Deployment.WindowsInstaller
{
    using System.Reflection;
    using System.Runtime.Loader;
    
    internal class CustomLoadContext : AssemblyLoadContext
    {
        public Assembly LoadFromFile(string path)
        {
            return base.LoadFromAssemblyPath(path);
        }
        
        protected override Assembly Load(AssemblyName assemblyName)
        {
            return base.LoadFromAssemblyName(assemblyName);
        }
    }
}