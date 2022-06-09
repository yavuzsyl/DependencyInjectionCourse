﻿namespace TheDependencyProblem.CarExample;

public class Car
{
    private readonly ICarEngine _carEngine;

    public Car(ICarEngine carEngine)
    {
        _carEngine = carEngine;
    }

    public void StartEngine()
    {
        _carEngine.Start();
    }

    //More methods
}

public class PetrolEngine : ICarEngine
{
    public void Start()
    {
        //Battery, induction coil, spark plug, fuel
    }
}


public class DieselEngine : ICarEngine
{
    public void Start()
    {
        //Battery, induction coil, spark plug, fuel
    }
}

public class TestEngine : ICarEngine
{
    public void Start()
    {
        //test engine
    }
}

public interface ICarEngine
{
    void Start();
}
