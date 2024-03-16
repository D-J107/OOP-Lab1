using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Corpus;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class JourneyShuttle : Ship
{
    public JourneyShuttle()
        : base(
            impulseEngine: new ImpulseEngineClassC(),
            jumpEngine: null,
            corpus: new CorpusClassI(),
            deflector: null,
            antiNitrinEmitter: null)
    { }
}