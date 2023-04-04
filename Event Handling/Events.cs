namespace Riposte.SDK
{
    /// <summary>
    /// Event class holding all Events that can be subscribed to by plugins.
    /// </summary>
    public class Events
    {
        /// <summary>
        /// Triggered when loaded into the game.
        /// </summary>
        public static event EventDelegate.OnGameStart OnGameStart;

        /// <summary>
        /// Triggered every Tick.
        /// </summary>
        public static event EventDelegate.OnUpdate OnUpdate;

        /// <summary>
        /// Triggered when a unit changes its path.
        /// </summary>
        public static event EventDelegate.OnPathChange OnPathChange;
    }
}
