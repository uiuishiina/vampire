using UnityEngine;

public class Bullet_Script : MonoBehaviour
{
    public GameObject Serch()
    {
        var g = GameObject.Find("GameManager");
        var e = g.GetComponent<GameManager>().EnemyInstance();
        if(e == null)return null;
        float Min = 100;GameObject G = null;
        foreach(var l in e)
        {
            var L = (l.transform.position - transform.position).magnitude;
            if (Min > L)
            {
                Min = L;
                G = l;
            }
        }
        return G;
    }
}
