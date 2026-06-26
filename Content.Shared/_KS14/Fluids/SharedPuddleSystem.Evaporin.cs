using Content.Shared.FixedPoint;
using Content.Shared.Fluids.Components;
using Content.Shared.Atmos.Piping.Components;

namespace Content.Shared.Fluids;

public abstract partial class SharedPuddleSystem
{
    protected virtual void ModifyEvaporationRate(Entity<PuddleComponent> puddle, ref FixedPoint2 evaporateRate) { }

    protected virtual void InitializeEvaporin()
    {
        SubscribeLocalEvent<PuddleComponent, AtmosDeviceTileChangedEvent>(OnAtmosChanged); //performance hell
    }
    protected virtual void OnAtmosChanged(Entity<PuddleComponent> puddle, ref AtmosDeviceTileChangedEvent args) { }
}
