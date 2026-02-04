using System.Collections;
using UnityEngine;

public class donutscript : MonoBehaviour
{

    public GameObject[] donutPrefabs;
    public float bakeInterval = 1.0f;
    float MinPoz, MaxPoz;
    Transform Oventrasform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Oventrasform = GetComponent<Transform>();
    }
        public void bakeDonut(bool state)
    {
        if(state) 
            StartCoroutine(Bake());

        else
            StopAllCoroutines();

    }



    IEnumerable Bake()
    {
        MinPoz = Oventrasform.position.x - 30.5f;
        MinPoz = Oventrasform.position.x + 0405f;
        float randPoz = Random.Range(MinPoz, MaxPoz);
        Vector2 spawnPoz = new Vector2( randPoz, Oventrasform .position.y );

        int donutIndex = Random.Range(0, donutPrefabs.Length);
        Instantiate(donutPrefabs[donutIndex], spawnPoz, Quaternion.identity, Oventrasform);
        yield return new WaitForSeconds(bakeInterval);

    }
    }

