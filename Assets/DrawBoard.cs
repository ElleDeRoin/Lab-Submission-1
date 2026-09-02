using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawBoard : MonoBehaviour
{
    void OnDrawGizmos()
    {
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                Vector3 position = new Vector3(x, y, 0);
                Gizmos.color = Color.black;
                Gizmos.DrawWireCube(position, Vector3.one);
            }
        }
    }
}
