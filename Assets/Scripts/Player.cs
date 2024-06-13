using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackStrategy
{
    void Attack(GameObject target);
}

public class FireAtack : IAttackStrategy
{
    public void Attack(GameObject target)
    {
        Debug.Log("FIREEEEEEE");
    }
}
public class WaterAtack : IAttackStrategy
{
    public void Attack(GameObject target)
    {
        Debug.Log("AGUA");
    }
}


public class Player : MonoBehaviour
{
    private IAttackStrategy attackStrategy;

    public void EscogerStrategy(IAttackStrategy strategy)
    {
        attackStrategy = strategy;
    }

    public void Attack(GameObject target)
    {
        attackStrategy.Attack(target);
    }
}

