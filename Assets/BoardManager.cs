using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
public class BoardManager : MonoBehaviour {

    [Serializable]
    public class Count {
        public int minimum;
        public int maximum;

        public Count (int min, int max) {
            minimum = min;
            maximum = max;
        }
    }
    public int columns = 8;
    public int rows = 8;
    public Count wallCount = new Count(5, 9);

    public GameObject[] boardTiles;
    public GameObject[] borderTiles;
    public GameObject[] walltiles;
    public GameObject[] resRedTiles;
    public GameObject[] resBlueTiles;
    public GameObject[] resGreenTiles;

    private Transform boardHolder;
    private List<Vector3> gridPositions = new List<Vector3>();

    void InitializeList() {
        gridPositions.Clear();

        for(int x = 1; x < columns - 1 ; x++) {
            for (int y = 1; y < rows - 1; y++) {
                gridPositions.Add(new Vector3(x, y, -10f));
            }
        }
    }

    void BoardSetup() {
        boardHolder = new GameObject("Board").transform;
        

        for (int x = 1; x < columns - 1; x++) {
            for (int y = 1; y < rows - 1; y++) {
                GameObject toInstantiate = boardTiles[Random.Range(0, boardTiles.Length)];
                if (x == -1 || x == columns || y == -1 || y == rows) {
                    toInstantiate = borderTiles[Random.Range(0, borderTiles.Length)];
                }
                    GameObject instance = Instantiate(toInstantiate, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;

                    instance.transform.SetParent(boardHolder);
                
            }
        }
    }

    Vector3 RandomPosition() {
        int randomIndex = Random.Range(0, gridPositions.Count);
        Vector3 randomPosition = gridPositions[randomIndex];
        gridPositions.RemoveAt(randomIndex);
        return randomPosition;
    }

    void LayoutObjectAtRandom(GameObject[] tileArray, int minimum, int maximum) {
        int objectCount = Random.Range(minimum, maximum + 1);
        for (int i = 0; i < objectCount; i++) {
            Vector3 randomPosition = RandomPosition();
            GameObject tileChoice = tileArray[Random.Range(0, tileArray.Length)];
            GameObject instance = Instantiate(tileChoice, randomPosition, Quaternion.identity) as GameObject;
            instance.transform.SetParent(boardHolder);
        }
    }

    public void SetupScene() {
        BoardSetup();
        InitializeList();
        LayoutObjectAtRandom(walltiles, wallCount.minimum, wallCount.maximum);
        LayoutObjectAtRandom(resRedTiles, 1, 1);
        LayoutObjectAtRandom(resBlueTiles, 1, 1);
        LayoutObjectAtRandom(resGreenTiles, 1, 1);

    }

    void Start() {
        //put in gamemanager when ready
        SetupScene();
        //HACK
        boardHolder.position = new Vector3(-5, -3, 0);
    }
}
