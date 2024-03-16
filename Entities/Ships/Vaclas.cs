using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Corpus;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Vaclas : Ship
{
    public Vaclas()
        : base(
            impulseEngine: new ImpulseEngineClassE(),
            jumpEngine: new JumpEngineClassGamma(),
            corpus: new CorpusClassII(),
            deflector: new DeflectorClassI(),
            antiNitrinEmitter: null)
    { }
}