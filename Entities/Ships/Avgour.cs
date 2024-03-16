using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Corpus;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Avgour : Ship
{
    public Avgour()
        : base(
            impulseEngine: new ImpulseEngineClassE(),
            jumpEngine: new JumpEngineClassAlpha(),
            corpus: new CorpusClassIII(),
            deflector: new DeflectorClassIII(),
            antiNitrinEmitter: null)
    { }
}