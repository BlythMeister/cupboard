using System.Collections.Generic;

namespace Cupboard.Sandbox;

public sealed class VSCode : Manifest
{
    public override void Execute(ManifestContext context)
    {
        if (!context.Facts.IsX86OrX64())
        {
            return;
        }

        var packages = new List<string>
        {
            "cake-build.cake-vscode",
            "matklad.rust-analyzer",
            "ms-vscode.powershell",
            "bungcip.better-toml",
            "ms-azuretools.vscode-docker",
            "octref.vetur",
            "ms-vscode-remote.remote-wsl",
            "jolaleye.horizon-theme-vscode",
            "vscode-icons-team.vscode-icons",
            "hediet.vscode-drawio",
        };

        // VSCode
        context.Resource<ChocolateyPackage>("vscode")
            .Ensure(PackageState.Installed)
            .After<PowerShell>("Install Chocolatey");

        // Extensions
        foreach (var package in packages)
        {
            context.Resource<VsCodeExtension>(package)
                .Ensure(PackageState.Installed)
                .After<ChocolateyPackage>("vscode");
        }
    }
}
