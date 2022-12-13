using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{ 
    public static Vector3 lastCheckPoint = new Vector3(0,-1,-1);
    public static Vector3 lastCheckPointStone = new Vector3(0, 0,0);
    // Start is called before the first frame update
    public void Awake()
    {
        GameObject.FindWithTag("Player").transform.position = lastCheckPoint;

        GameObject.FindWithTag("Stone").transform.position = lastCheckPointStone;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
