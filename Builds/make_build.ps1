Write-Host "BuildProcess for NetSIPServer"

$buildVerbosity = "q"

$newBuildFolder = Get-Date -Format "ddMMyyyy"
$startFolder = $pwd
$frameworkVersion = "v3.5"
$frameworkFolder = "C:\Windows\Microsoft.Net\Framework\$frameworkVersion\"
$msbuildFile = $frameworkFolder + "MSbuild.exe"

Set-Alias msbuild $msbuildFile

cd ..\Server\SIPServer\

msbuild .\SIPServer.sln /t:Rebuild /p:Configuration=Release /v:$buildVerbosity /fileLogger /nologo
msbuild .\SIPServer.sln /t:Rebuild /p:Configuration=Release /v:$buildVerbosity /fileLogger /p:Platform=x86  /nologo
#msbuild .\SIPServer.sln /t:Rebuild /p:Configuration=Release /v:n /fileLogger /p:Platform=x64

cd $startFolder

cd .\Releases\
$releaseName = (Get-Date -Format "ddMMyyyy")

if((Test-Path $releaseName) -eq $false)
{
 Write-Host -ForegroundColor White "Release-Folder $releaseName will be created."
 New-Item $releaseName -Type Directory
 cd $releaseName
 New-Item "x86" -Type Directory
}

cd $startFolder

Write-Host -ForegroundColor Yellow -nonewline "Old files will be removed in the Releasefolder"
Write-Debug ".\Releases\$releaseName\x86\*"
Remove-Item .\Releases\$releaseName\x86\*
Write-Host -ForegroundColor Yellow " OK"

Write-Host -ForegroundColor Green -nonewline "New Files will be copied into the Releasefolder"
Write-Debug ".\TempOutput\Release\x86\* .\Releases\$releaseName\x86\"
Copy-Item .\TempOutput\Release\x86\* .\Releases\$releaseName\x86\
Write-Host -ForegroundColor Green " OK"

cd $startFolder