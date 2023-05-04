using System;
using Exiled.Events.EventArgs.Scp330;
using InventorySystem.Items.Usables.Scp330;

namespace BringBackPinkCandy
{
    public class CandyGrabHandle
    {
        private int Chance = PinkCandyPlugin.Instance.Config.Chance;
        public void OnGrabCandy(InteractingScp330EventArgs interactingScp330EventArgs)
        {
            Random random = new Random();
            if (random.Next(0, 100) < Chance)
            {
                interactingScp330EventArgs.Candy = CandyKindID.Pink;
            }
        }
    }
}