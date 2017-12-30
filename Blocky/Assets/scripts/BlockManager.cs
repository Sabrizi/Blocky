using Assets.scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{

    public GameObject blockPF;

    public List<GameObject> blocks = new List<GameObject>();

    private const float BLOCK_SCALE = 0.5f;

    // Use this for initialization
    void Start()
    {
        for (float i = 0; i < 10; i++)
        {
            for (float j = 0; j < 10; j++)
            {
                GameObject block = Instantiate(blockPF);
                block.transform.parent = transform;
                block.GetComponent<SpriteRenderer>().color = ColorHelper.Brown;
                block.transform.position = new Vector3(i * BLOCK_SCALE, j * BLOCK_SCALE);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
