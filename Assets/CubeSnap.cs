using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
[SelectionBase]
public class CubeSnap : MonoBehaviour {
    [SerializeField] [Range(1f,20f)] float gridSize = 10f;

    TextMesh textMesh;

     void Update()
     {
        Vector3 snapPOS;
        snapPOS.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        snapPOS.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize; 
        transform.position = new Vector3(snapPOS.x, 0f, snapPOS.z);

        textMesh = GetComponentInChildren<TextMesh>();
        textMesh.text = snapPOS.x/gridSize + "," + snapPOS.z/gridSize ;


     }

 
    
}
