![QuickLook icon](https://user-images.githubusercontent.com/1687847/29485863-8cd61b7c-84e2-11e7-97d5-eacc2ba10d28.png)

# QuickLook.Plugin.OfficeViewer (Native)

This plugin renders MS Word, Excel, and PowerPoint files with native components provided by existing `Microsoft Office suite` or `WPS Office`.

## Differences with [`OfficeViewer`](https://github.com/QL-Win/QuickLook.Plugin.OfficeViewer)

1. **`OfficeViewer-Native` requires an `Microsoft Office suite` or `WPS Office` installation,** whereas `OfficeViewer` does not.
2. `OfficeViewer-Native` renders documents better than ``OfficeViewer`` in most cases.

## Try out

1. Go to [Release page](https://github.com/QL-Win/QuickLook.Plugin.OfficeViewer-Native/releases) and download the latest version.
2. Make sure that you have QuickLook running in the background. Go to your Download folder, and press <key>Spacebar</key> on the downloaded `.qlplugin` file.
3. Click the “Install” button in the popup window.
4. Restart QuickLook.
5. Select the file and press <key>Spacebar</key>.

## Development

 1. Clone this project. Do not forget to update submodules.
 2. Build project with `Release` profile.
 3. Run `Scripts\pack-zip.ps1`.
 4. You should find a file named `QuickLook.Plugin.OfficeViewer.qlplugin` in the project directory.

## License

MIT License.
