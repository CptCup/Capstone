using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour
{

    private int levelWidth, levelHeight;

    public Transform woodTile, wallTile;

    public Color woodColor, wallColor;

    public Color[] tileColors;

    public Texture2D levelTexture;

    public Entities[] entitie;

    // Use this for initialization

    void Start()
    {
        levelWidth = levelTexture.width;
        levelHeight = levelTexture.height;
        loadLevel();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void loadLevel()
    {
        tileColors = new Color[levelWidth * levelHeight];
        tileColors = levelTexture.GetPixels();

        int posY = (int)GetComponent<Transform>().position.y;
        int posX = (int)GetComponent<Transform>().position.x;
        for (int y = 0; y < levelHeight; y++)
        {
            for (int x = 0 ; x < levelWidth; x++)
            {
                if (tileColors[x+y*levelWidth] == woodColor)
                {
                    Instantiate(woodTile, new Vector2(posX, posY), Quaternion.identity);
                }
                if (tileColors[x+y*levelHeight] == wallColor)
                {
                    Instantiate(wallTile, new Vector2(posX, posY), Quaternion.identity);
                }
                posX++;
            }
            posX= (int)GetComponent<Transform>().position.x; ;
            posY++;
        }
    }
}