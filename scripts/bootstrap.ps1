#
# Run a build using Psake
#

# Bootstrap - make sure we have Psake available

$psakeModule = get-module psake

if ($psakeModule -eq $null) {
    # Don't already have psake loaded, try to load it from a default location
    import-module psake -ErrorAction SilentlyContinue
    $psakeModule = get-module psake
}

if ($psakeModule -eq $null) {
    # Still don't  have psake loaded, try find it through NuGet
    $path = Resolve-Path $env:USERPROFILE\.nuget\psake\*\psake.psm1
    if ($path -eq $null) {
        $path = Resolve-Path $env:NugetMachineInstallRoot\psake\*\psake.psm1
    }

    if ($path -ne $null) {
        import-module $path -ErrorAction SilentlyContinue
        $psakeModule = get-module psake
    }
}

$psakePath = $psakeModule.Path

Write-Host "Using psake from $psakePath"




