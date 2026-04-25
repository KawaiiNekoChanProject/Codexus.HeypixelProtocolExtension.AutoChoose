using Codexus.Development.SDK.Manager;
using Codexus.Development.SDK.Plugin;
using Codexus.HeypixelExtension.Events;

namespace Codexus.HeypixelExtension.AutoChoose;

[Development.SDK.Attributes.Plugin(
    "00AB0E97-71E1-4F59-873B-4B9B6EF9729A",
    "Heypixel Protocol Extension Auto Choose",
    "Automatically assists the player in making selections under special conditions.",
    "NekoCurit",
    "0.0.3",
    [
        "00AB0E97-71E1-4F59-873B-4B9B6EF9729C"
    ])
]
public class AutoChoose : IPlugin
{
    
    public void OnInitialize()
    {
        EventManager.Instance.RegisterHandler<EventHeypixelCrossPlatformGuiModal>(HeypixelExtension.PluginChannel, OnHeypixelCrossPlatformGuiModal);
    }

    public static void OnHeypixelCrossPlatformGuiModal(EventHeypixelCrossPlatformGuiModal e)
    {
        if (e.Modal.Title.Contains("是否撤离")) e.Click(true);
    }

}