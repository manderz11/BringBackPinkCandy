using System;
using Exiled.API.Features;

namespace BringBackPinkCandy
{
    public class PinkCandyPlugin : Plugin<Config>
    {
        public override string Name => "Bring back pink candy";
        public override string Author => "manderz11";
        public override Version Version => new Version(1, 0, 1);
        private CandyGrabHandle candyGrabHandle;
        private static readonly PinkCandyPlugin Singleton = new();

        private PinkCandyPlugin(){}
        
        public static PinkCandyPlugin Instance => Singleton;
        
        public override void OnEnabled()
        {
            candyGrabHandle = new CandyGrabHandle();
            Exiled.Events.Handlers.Scp330.InteractingScp330 += candyGrabHandle.OnGrabCandy;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Scp330.InteractingScp330 -= candyGrabHandle.OnGrabCandy;
            candyGrabHandle = null;
            base.OnDisabled();
        }
    }
}