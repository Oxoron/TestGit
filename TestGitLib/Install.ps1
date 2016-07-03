param($installPath, $toolsPath, $package, $project)

Write-Host $toolsPath
Write-Host $project

$toolsParent = Split-Path -Path $toolsPath -Parent
$libPath = Join-Path (Join-Path $toolsParent "lib") "4.6"
$dllPath = Join-Path $libPath "TestGitLib.dll"

Write-Host $dllPath
if($project.Object.References)
{
	Write-Host "FullPath: " $dllPath
    $project.Object.References.Add($dllPath)
}  