using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teacher_cube : MonoBehaviour
{
    [Header("方塊")]
        public GameObject cube;
    void Start()
    {
        #region
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < (i+1); j++)
            {
                Vector3 pos = new Vector3(i * 2, j*2, 25);

                Instantiate(cube, pos, Quaternion.identity);
            }
        }
        #endregion
    }

}

