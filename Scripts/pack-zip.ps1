Remove-Item ..\QuickLook.Plugin.OfficeViewer.qlplugin -ErrorAction SilentlyContinue

$files = Get-ChildItem -Path ..\Build\Release\ -Exclude *.pdb,*.xml
Compress-Archive $files ..\QuickLook.Plugin.OfficeViewer.zip
Move-Item ..\QuickLook.Plugin.OfficeViewer.zip ..\QuickLook.Plugin.OfficeViewer.qlplugin