using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysManager : MonoBehaviour
{
    [SerializeField] GameObject[] objectsCollection;
    [SerializeField] int randomNumber;
    [SerializeField] Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        objectsCollection = GameObject.FindGameObjectsWithTag("ObjetoLab");
        AgregarColliderAElementosDelArray();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PosicionarElementosDelArray();
            GenerarNumeroAlAzar();
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            InstanciarObjetoAlAzar();
        }
    }

    void DestruirElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            Destroy(objectsCollection[i]);
        }
    }

    void PosicionarElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            objectsCollection[i].transform.position = new Vector3(15.4f + i, 0.2f, 9.3f);
        }
    }

    void AgregarColliderAElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            objectsCollection[i].AddComponent<BoxCollider>();
        }
    }

    void GenerarNumeroAlAzar()
    {
        randomNumber = Random.Range(1, 11);
    }

    void InstanciarObjetoAlAzar()
    {
        Instantiate(objectsCollection[Random.Range(0, objectsCollection.Length)], spawnPoint.position, Quaternion.identity);
    }
}
