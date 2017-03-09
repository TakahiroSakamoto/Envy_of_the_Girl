using UnityEngine;

public class Fader : MonoBehaviour
{
    public Material m_Material;

    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Graphics.Blit(src, dest, m_Material);
    }
}