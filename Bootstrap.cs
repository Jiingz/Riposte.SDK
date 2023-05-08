namespace Riposte.SDK
{
    public static class Bootstrap
    {
        private static bool _initialized;

        public static bool Init()
        {
            if (_initialized)
                return false;



            _initialized = true;

            return true;
        }
    }
}
