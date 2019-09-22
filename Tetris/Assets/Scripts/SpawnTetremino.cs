using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTetremino : MonoBehaviour
{
    public GameObject[] Tetrominoes;
    // Start is called before the first frame update
    void Start()
    {
        NewTetromino();
        //NextTetromino();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewTetromino()
    {
        Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)],transform.position,Quaternion.identity);
    }

    void NextTetromino()
    {
        //Instantiate(Tetrominoes[Random.Range(1, Tetrominoes.Length)], new Vector2(15, 9), Quaternion.identity);
    }
}