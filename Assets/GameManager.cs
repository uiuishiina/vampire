using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField, Header("Player")] GameObject Player;
    [SerializeField, Header("Speed")] float Speed = 0.5f;
    public void SomonEnemy(GameObject E)
    {
        Instantiate(E);
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
}