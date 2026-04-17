
using Celeste.Mod.Entities;
using Monocle;
using Microsoft.Xna.Framework;

namespace Celeste.Mod.NikolaHelper.Entities;

[CustomEntity("NikolaHelper/LockPlayerState")]
public class LockPlayerState : Trigger
{
    private readonly bool lockState;

    // Used when loading the trigger from a map
    // Remember to call base(data, offset)!
    public LockPlayerState(EntityData data, Vector2 offset) : base(data, offset)
    {
        lockState = data.Bool("lockState");
    }

    // Log when Madeline enters the trigger
    public override void OnEnter(Player player)
    {
        player.StateMachine.Locked = lockState;
    }

}