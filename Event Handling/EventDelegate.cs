using Riposte.SDK.Args;

namespace Riposte.SDK
{
    //Delegates for all Events.
    public class EventDelegate
    {
        /// <summary>
        /// Triggered when loaded into the game.
        /// </summary>
        public delegate void OnGameStart();

        /// <summary>
        /// Triggered every Tick.
        /// </summary>
        public delegate void OnUpdate();

        /// <summary>
        /// Triggered when a unit changes its path.
        /// </summary>
        public delegate void OnPathChange(OnPathChangeArgs args);
    }
}
