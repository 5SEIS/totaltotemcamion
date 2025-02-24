using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrasasScreen : InfoScreen
{
    public Button[] prodButtons;
    public Sprite btnOnSprite;
    public Sprite btnOffSprite;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }

    public override void SetScreen(string prodName)
    {
        base.SetScreen(prodName);
        prodButtons[0].image.sprite = prodName == "A" ? btnOnSprite : btnOffSprite;
        prodButtons[1].image.sprite = prodName == "B" ? btnOnSprite : btnOffSprite;
        prodButtons[2].image.sprite = prodName == "C" ? btnOnSprite : btnOffSprite;
        _myAnim.SetBool("ProdA", prodName == "A");
        _myAnim.SetBool("ProdB", prodName == "B");
        _myAnim.SetBool("ProdC", prodName == "C");
    }

    public override void DisableScreen()
    {
        base.DisableScreen();
        prodButtons[0].image.sprite = btnOnSprite;
        prodButtons[1].image.sprite = btnOnSprite;
        prodButtons[2].image.sprite = btnOnSprite;
        _myAnim.SetBool("ProdA", false);
        _myAnim.SetBool("ProdB", false);
        _myAnim.SetBool("ProdC", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
