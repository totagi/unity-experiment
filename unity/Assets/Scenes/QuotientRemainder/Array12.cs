using UnityEngine;
using TMPro;

public class Array12 : MonoBehaviour
{
    const int YOKO = 7;
    [SerializeField] TextMeshProUGUI m_Prefab;
    [SerializeField] Transform m_Parent;
    private string[] array = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" };
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < array.Length; i++)
        {
            int tate = i / YOKO;
            int yoko = i % YOKO;
            TextMeshProUGUI text = Instantiate(m_Prefab, m_Parent, false);
            text.gameObject.SetActive(true);
            text.text = array[i];
            text.transform.localPosition = new Vector3(-350 + (yoko * 100), -(tate * 100));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
