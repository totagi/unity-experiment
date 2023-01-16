using UnityEngine;
using TMPro;

public class QuotientRemainder : MonoBehaviour
{
    [SerializeField]float m_Base;
    [SerializeField] TextMeshProUGUI m_CounterText;

    private double m_Time;
    // Start is called before the first frame update
    void Start()
    {
        m_Time = m_Base;
    }

    // Update is called once per frame
    void Update()
    {
        m_Time += Time.deltaTime;
        int h = (int)(m_Time / 3600);
        int m = (int)((m_Time % 3600) / 60);
        int s = (int)(m_Time % 60);
        m_CounterText.text = $"{h}:{m}:{s}";
    }
}
