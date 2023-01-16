using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    private int[] array = {1,2,3,4,5,6,7,8,9};
    // Start is called before the first frame update
    void Start()
    {
        for(int i =0;i<array.Length;i++){
            int nextIndex = (i - 1 + array.Length) % array.Length;
            int sum = array[i] + array[nextIndex] ;
            Debug.Log(sum +"="+ i+":"+nextIndex);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
