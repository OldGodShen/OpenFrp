@echo off
echo Be sure you have built OpenFrp.Linux.
pause
echo Cleaning Pack Folder...
rd /s /q OpenFrp.Linux.Pack
echo Creating pack folder...
mkdir OpenFrp.Linux.Pack
mkdir OpenFrp.Linux.Pack\frpc
mkdir OpenFrp.Linux.Pack\program
echo Copying bin files...
copy src\frpc_bin\frpc_linux_386 .\OpenFrp.Linux.Pack\frpc\386
copy src\frpc_bin\frpc_linux_amd64 .\OpenFrp.Linux.Pack\frpc\amd64
copy src\frpc_bin\frpc_linux_arm64 .\OpenFrp.Linux.Pack\frpc\arm64
copy src\frpc_bin\frpc_linux_arm .\OpenFrp.Linux.Pack\frpc\arm
copy src\OpenFrp.Linux\OpenFrp.Linux.i386\bin\x86\Debug\OpenFrp.Linux.i386.out OpenFrp.Linux.Pack\program\386
copy src\OpenFrp.Linux\OpenFrp.Linux.amd64\bin\x64\Debug\OpenFrp.Linux.amd64.out OpenFrp.Linux.Pack\program\amd64
copy src\OpenFrp.Linux\OpenFrp.Linux.arm64\bin\ARM64\Debug\OpenFrp.Linux.arm64.out OpenFrp.Linux.Pack\program\arm64
copy src\OpenFrp.Linux\OpenFrp.Linux.arm\bin\ARM\Debug\OpenFrp.Linux.arm.out OpenFrp.Linux.Pack\program\arm
echo Generating install scripts...
copy src\OpenFrp.Linux.Installer\install.sh OpenFrp.Linux.Pack
copy src\OpenFrp.Linux.Installer\uninstall.sh OpenFrp.Linux.Pack
echo Done!
