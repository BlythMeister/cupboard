namespace Cupboard;

[PublicAPI]
public sealed class ResourcesModule : ServiceModule
{
    public override void Configure(IServiceCollection services)
    {
        // Resources
        services.AddSingleton<IResourceProvider, DirectoryProvider>();
        services.AddSingleton<IResourceProvider, DownloadProvider>();
        services.AddSingleton<IResourceProvider, ExecProvider>();
        services.AddSingleton<IResourceProvider, FileProvider>();
        services.AddSingleton<IResourceProvider, PowerShellProvider>();
        services.AddSingleton<IResourceProvider, VsCodeExtensionProvider>();

        // Facts
        services.AddSingleton<IFactProvider, ArgumentFacts>();
        services.AddSingleton<IFactProvider, EnvironmentFacts>();
        services.AddSingleton<IFactProvider, MachineFacts>();
    }
}
