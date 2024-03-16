using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Corpus;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ShipParts.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Stella : Ship
{
    public Stella()
        : base(
            impulseEngine: new ImpulseEngineClassC(),
            jumpEngine: new JumpEngineClassOmega(),
            corpus: new CorpusClassI(),
            deflector: new DeflectorClassI(),
            antiNitrinEmitter: null)
    { }
}