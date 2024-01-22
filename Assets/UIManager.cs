using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MenuUtama, MenuInformasi, MenuMateri;
    // Start is called before the first frame update
    void Start()
    {
        MenuUtama.DOAnchorPos(Vector2.zero, 0f);
    }
    public void MenuInformasibutton()
    {
        MenuUtama.DOAnchorPos(new Vector2(0, -3664), 0.25f);
        MenuInformasi.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void CloseMenuInformasi()
    {
        MenuUtama.DOAnchorPos(new Vector2(0, 0), 0.25f);
        MenuInformasi.DOAnchorPos(new Vector2(1920, 0), 0.25f);
    }
    public void MenuMateributton()
    {
        MenuUtama.DOAnchorPos(new Vector2(0, -3664), 0.25f);
        MenuMateri.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void CloseMenuMateri()
    {
        MenuUtama.DOAnchorPos(new Vector2(0, 0), 0.25f);
        MenuMateri.DOAnchorPos(new Vector2(-1920, 0), 0.25f);
    }
}
