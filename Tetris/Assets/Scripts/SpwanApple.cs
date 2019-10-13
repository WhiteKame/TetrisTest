using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnApple : MonoBehaviour
{
    public GameObject ApplePrefab;

    public static int width = 24;
    public static int height = 30;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("newApple", 3, 10);
    }

    void newApple()
    {
        int x = (int)Random.Range(0, width);
        int y = (int)Random.Range(0, height);

        Instantiate(ApplePrefab, new Vector2(x, y), Quaternion.identity);
    }
}
