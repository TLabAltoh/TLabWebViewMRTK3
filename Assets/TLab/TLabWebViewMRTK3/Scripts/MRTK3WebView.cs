using UnityEngine;
using TLab.Android.WebView;

namespace TLab.XR.MRTK
{
    public class MRTK3WebView : MonoBehaviour
    {
        [SerializeField] private TLabWebView m_webview;
        [SerializeField] private GameObject m_keyborad;

        public void SwitchKeyborad()
        {
            m_keyborad.SetActive(!m_keyborad.activeSelf);
        }
    }
}
