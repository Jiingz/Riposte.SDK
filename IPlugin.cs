namespace Riposte.SDK
{
    /// <summary>
    /// Plugin Interface which should be implemented by every Plugin.
    /// </summary>
    public interface IPlugin
    {
        string PluginName { get; }
        string PluginVersion { get; }
        string PluginDescription { get; }
        PluginType PluginType { get; }

        /// <summary>
        /// Triggered once after the plugin has been loaded.
        /// Subscribe your callbacks here.
        /// </summary>
        void OnLoad();
    }
}