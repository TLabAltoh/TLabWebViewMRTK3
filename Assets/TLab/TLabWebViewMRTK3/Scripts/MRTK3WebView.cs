using UnityEngine;
using TLab.VKeyborad;
using TLab.Android.WebView;

namespace TLab.XR.MRTK
{
    public class MRTK3WebView : MonoBehaviour
    {
        [SerializeField] private TLabWebView m_webview;
        [SerializeField] private TLabVKeyborad m_keyborad;

        public void SwitchKeyborad() => m_keyborad.SetVisibility(!m_keyborad.isVisible);
    }
}
