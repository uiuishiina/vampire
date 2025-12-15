using NUnit.Framework;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField, Header("Player")] GameObject Player;
    [SerializeField, Header("Speed")] float Speed = 0.5f;
    [SerializeField]List<GameObject> EnemyList_;
    public void SomonEnemy(GameObject E)
    {
        var e = Instantiate(E);
        EnemyList_.Add(e);
    }

    public object PlayerInstanse()
    {
        Debug.Log(Player);
        return Player;
    }

    public float SetSpeed()
    {
        return Speed;
    }

    public List<GameObject> EnemyInstance()
    {
        return EnemyList_;
    }

    public void RemoveE(GameObject E)
    {
        EnemyList_.Remove(E);
    }
}