$output_dir="..\bin\Release\net7.0\publish"
$linux_profile="linux-x64"
$windows_profile="win-x64"
$osx_profile="osx-x64"
$project="ToClip"

if (!(Test-Path "variable:output_dir") -or !$output_dir) {
    throw "output_dir was null or undefined!"
}

Remove-Item -Path $output_dir\* -Recurse

dotnet publish -c Release -p:PublishProfile=$linux_profile ..\$project.csproj
dotnet publish -c Release -p:PublishProfile=$osx_profile ..\$project.csproj
dotnet publish -c Release -p:PublishProfile=$windows_profile ..\$project.csproj

Remove-Item -Path $output_dir\$linux_profile\*.pdb
Remove-Item -Path $output_dir\$osx_profile\*.pdb
Remove-Item -Path $output_dir\$windows_profile\*.pdb

Compress-Archive -LiteralPath $output_dir\$linux_profile\ -DestinationPath $output_dir\$linux_profile.zip
Compress-Archive -LiteralPath $output_dir\$osx_profile\ -DestinationPath $output_dir\$osx_profile.zip
Compress-Archive -LiteralPath $output_dir\$windows_profile\ -DestinationPath $output_dir\$windows_profile.zip

Invoke-Item $output_dir
