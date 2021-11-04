using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Zen.Uno.App.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new Zen.Uno.App.App(), args);
            host.Run();
        }
    }
}
