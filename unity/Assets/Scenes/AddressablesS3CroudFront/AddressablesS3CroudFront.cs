using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

public class AddressablesS3CroudFront : MonoBehaviour
{
    [SerializeField] private RawImage m_RawImage;
    // Start is called before the first frame update
    async void Start()
    {
        var tex2D = await Addressables.LoadAssetAsync<Texture2D>("Assets/Scenes/AddressablesS3CroudFront/cat.png").Task;
        m_RawImage.texture = tex2D;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
