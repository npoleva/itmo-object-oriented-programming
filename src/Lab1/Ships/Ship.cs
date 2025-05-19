using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.HullStrengthClasses;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Surroundings;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public abstract class Ship
{
    private readonly List<Engine> _enginesList;
    private readonly List<Deflector> _deflectorList;
    protected Ship(HullStrengthClass hullStrengthClass)
    {
        HullStrengthClass = hullStrengthClass;
        _enginesList = new List<Engine>();
        _deflectorList = new List<Deflector>();
    }

    public abstract bool HasAntinitrineEmitter { get; }
    public bool IsDestroyed { get; private set; }
    public bool CrewCasuality { get; private set; }

    public bool HasDeflectors => CheckDeflectorsPresence();
    public IEnumerable<Engine> Engines => _enginesList;

    public IEnumerable<Deflector> Deflectors => _deflectorList;
    public bool HasPhotonDeflectors { get; protected set; }
    protected HullStrengthClass HullStrengthClass { get; }

    internal void Damaging(
        Surrounding surrounding)
    {
        foreach (IObstacle obstacle in surrounding.Obstacles)
        {
            ReceiveDamage(obstacle.DefectDamage());
        }
    }

    protected abstract void ReceiveDamage(IObstacle obstacle);

    protected void CrewHasDied()
    {
        CrewCasuality = true;
    }

    protected void AddEngine(Engine? engine)
    {
        if (engine != null) _enginesList.Add(engine);
    }

    protected void AddDeflector(Deflector? deflector)
    {
        if (deflector != null) _deflectorList.Add(deflector);
    }

    protected void TryAddPhotonDeflector()
    {
        if (HasPhotonDeflectors) _deflectorList.Add(new PhotonDeflector());
    }

    protected void Destroy()
    {
        IsDestroyed = true;
    }

    private bool CheckDeflectorsPresence()
    {
        return Deflectors.Any(tmp => tmp.IsWorking);
    }
}