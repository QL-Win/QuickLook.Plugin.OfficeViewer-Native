using System.IO;
using System.Windows;
using System.Windows.Controls;
using QuickLook.Common.Plugin;

namespace QuickLook.Plugin.HelloWorld
{
    public class Plugin : IViewer
    {
        public int Priority => 0;

        public void Init()
        {
        }

        public bool CanHandle(string path)
        {
            return !Directory.Exists(path) && path.ToLower().EndsWith(".zzz");
        }

        public void Prepare(string path, ContextObject context)
        {
            context.PreferredSize = new Size {Width = 600, Height = 400};
        }

        public void View(string path, ContextObject context)
        {
            var viewer = new Label {Content = "I am a Label. I do nothing at all."};

            context.ViewerContent = viewer;
            context.Title = $"{Path.GetFileName(path)}";

            context.IsBusy = false;
        }

        public void Cleanup()
        {
        }
    }
}