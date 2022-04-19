using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject trash, recycle, compost, dirty;
    public float spawnDelay;

    private List<GameObject> objects = new List<GameObject>();


    void Start()
    {
        objects.Add(trash);
        objects.Add(recycle);
        objects.Add(compost);
        objects.Add(dirty);

        StartCoroutine(spawnTrash());
    }

    IEnumerator spawnTrash()
    {
        int random;
        while (true)
        {
            random = Random.Range(0, 4);
            Instantiate(objects[random], transform.position, transform.rotation);

            yield return new WaitForSeconds(spawnDelay);
        }

    }

}
