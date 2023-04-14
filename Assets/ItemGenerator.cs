using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject carPrefab;

    public GameObject coinPrefab;

    public GameObject conePrefab;

    public int startPos = 80;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject unitychan = GameObject.Find("unitychan");

        float itemGeneratorPos = unitychan.transform.position.z + 45;

        int goalPos = 360;

        float posRange = 3.4f;

        if (itemGeneratorPos >= startPos && startPos <= goalPos)
        {


            int num = Random.Range(1, 11);
            if (num <= 2)
            {

                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, itemGeneratorPos);
                }
            }
            else
            {

                for (int j = -1; j <= 1; j++)
                {
                    int item = Random.Range(1, 11);

                    int offsetZ = Random.Range(-5, 6);

                    if (1 <= item && item <= 6)
                    {
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, itemGeneratorPos + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, itemGeneratorPos + offsetZ);
                    }
                }

            }
            startPos += 15;
        }
    }
}
