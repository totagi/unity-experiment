using System.Reflection;
using UnityEngine;


/// <summary>
/// アニメーションクリップ生成
/// </summary>
public class CreateAnimationClip : MonoBehaviour
{
    private double m_Counter;

    [SerializeField] Transform m_Target;

    private readonly string m_ClipName = "test";
    private readonly float m_FrameRate = 60;
    private AnimationClip m_Clip;
    private AnimationCurve m_AnimPosX;
    private AnimationCurve m_AnimPosY;
    private AnimationCurve m_AnimPosZ;
    private AnimationCurve m_AnimRotX;
    private AnimationCurve m_AnimRotY;
    private AnimationCurve m_AnimRotZ;
    private AnimationCurve m_AnimRotW;

    // Start is called before the first frame update
    void Start()
    {
        m_Counter = 0;

        m_Clip = new AnimationClip();
        m_AnimPosX = new AnimationCurve();
        m_AnimPosY = new AnimationCurve();
        m_AnimPosZ = new AnimationCurve();
        m_AnimRotX = new AnimationCurve();
        m_AnimRotY = new AnimationCurve();
        m_AnimRotZ = new AnimationCurve();
        m_AnimRotW = new AnimationCurve();
    }

    // Update is called once per frame
    void Update()
    {
        SetAnimationCurve((float)m_Counter, m_Target);
        m_Counter += Time.deltaTime;
        if (m_Counter >= 10)
        {

            CreateClip();
#if UNITY_EDITOR
            UnityEditor.AssetDatabase.CreateAsset(m_Clip, "Assets/Scenes/CreateAnimationClip/" + m_ClipName + ".anim");
            UnityEditor.EditorApplication.isPlaying = false;
#endif

        }
    }

    public void SetAnimationCurve(float time, Transform transform)
    {
        m_AnimPosX.AddKey(time, transform.position.x);
        m_AnimPosY.AddKey(time, transform.position.y);
        m_AnimPosZ.AddKey(time, transform.position.z);
        m_AnimRotX.AddKey(time, transform.rotation.x);
        m_AnimRotY.AddKey(time, transform.rotation.y);
        m_AnimRotZ.AddKey(time, transform.rotation.z);
        m_AnimRotW.AddKey(time, transform.rotation.w);
    }

    public void CreateClip()
    {
        System.Type anim = m_Clip.GetType();
        PropertyInfo propertyInfoa = anim.GetProperty("frameRate");
        propertyInfoa.SetValue(m_Clip, m_FrameRate);
        m_Clip.name = m_ClipName;
        m_Clip.SetCurve("", typeof(Transform), "localPosition.x", m_AnimPosX);
        m_Clip.SetCurve("", typeof(Transform), "localPosition.y", m_AnimPosY);
        m_Clip.SetCurve("", typeof(Transform), "localPosition.z", m_AnimPosZ);
        m_Clip.SetCurve("", typeof(Transform), "localRotation.y", m_AnimRotX);
        m_Clip.SetCurve("", typeof(Transform), "localRotation.x", m_AnimRotY);
        m_Clip.SetCurve("", typeof(Transform), "localRotation.z", m_AnimRotZ);
        m_Clip.SetCurve("", typeof(Transform), "localRotation.z", m_AnimRotW);

    }


}