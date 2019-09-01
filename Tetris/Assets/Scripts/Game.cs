using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static int gridWidth = 10;
    public static int gridHeight = 20;

    // Start is called before the first frame update
    void Start()
    {
        SpawnNextTetromino();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnNextTetromino()
    {
        GameObject nextTetris = (GameObject)Instantiate(Resources.Load(GetRandomTetromino(), typeof(GameObject)), new Vector2(5.0f, 20.0f), Quaternion.identity);
    }

    public bool CheckIsInsideGrid(Vector2 pos)
    {
        return ((int)pos.x >= 0 && (int)pos.x < gridWidth && (int)pos.y >= 0);
    }

    public Vector2 Round (Vector2 pos)
    {
        return new Vector2(Mathf.Round(pos.x), Mathf.Round(pos.y));
    }

    string GetRandomTetromino()
    {
        int radomTetromino = Random.Range(1, 8);

        string randomTetrominoName = "Prefabs/T";

        switch (radomTetromino)
        {
            case 1:
                randomTetrominoName = "Prefabs/T";
                break;
            case 2:
                randomTetrominoName = "Prefabs/Long";
                break;
            case 3:
                randomTetrominoName = "Prefabs/Square";
                break;
            case 4:
                randomTetrominoName = "Prefabs/J";
                break;
            case 5:
                randomTetrominoName = "Prefabs/S";
                break;
            case 6:
                randomTetrominoName = "Prefabs/Z";
                break;
            case 7:
                randomTetrominoName = "Prefabs/L";
                break;
        }

        return randomTetrominoName;
    }
}
