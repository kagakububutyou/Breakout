using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using System;

public class CSVLoader : MonoBehaviour {

    [SerializeField]
    private GameObject src = null;

    private void Start()
    {
        for (int x = 0; x < 10; x++)
        {
            float posX = src.transform.position.x + src.transform.localScale.x * x;
            float posY = src.transform.position.y;
            float posZ = src.transform.position.z;
            Instantiate(src, new Vector3(posX, posY, posZ), Quaternion.identity);
        }
    }
    
}
