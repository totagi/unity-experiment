using UnityEngine;
using TMPro;

public class TimerCountDown : MonoBehaviour
{
    [SerializeField] double m_CounterMax;
    [SerializeField] double m_Counter;  // double
    [SerializeField] TextMeshProUGUI m_CounterText;

    // Start is called before the first frame update
    void Start()
    {
        m_Counter = m_CounterMax;
    }

    // Update is called once per frame
    void Update()
    {
        m_Counter += Time.deltaTime;
        m_CounterText.text = m_Counter.ToString("F2");
    }

}
