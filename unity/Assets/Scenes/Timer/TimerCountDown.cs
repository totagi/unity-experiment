using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountDown : MonoBehaviour
{
    [SerializeField]Text hoge;
    // Start is called before the first frame update
    void Start()
    {
        float hoge = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
    }

}
