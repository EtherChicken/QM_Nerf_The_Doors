using HarmonyLib;
using MGSC;
using UnityEngine;

namespace Nerf_the_Doors_Continued
{
    [HarmonyPatch(typeof(PlayerInteractionSystem),nameof(PlayerInteractionSystem.EndPlayerTurn))]
    class DoorPatch
    {
        public static bool Prefix(Creatures creatures, PlayerEndTurnContext context = PlayerEndTurnContext.None)
        {
            // Not sure if you can do it with a postfix, this is the easiest way I can tell.
            if (context == PlayerEndTurnContext.MapObstacleInteraction)
            {
                if (creatures.Player.FreeInteractObstacles)
                {
                    return false;
                }
                if (creatures.Player.ActionPointsLeft == 1)
                {
                    return false;
                    
                }
                creatures.Player.AnyActionProcessedFlag = true;
            }
            if (context == PlayerEndTurnContext.InventoryInteraction)
                creatures.Player.AnyActionProcessedFlag = true;
            else
                creatures.Player.IsProcessing = false;
            return false;
        } 
    }
    
}