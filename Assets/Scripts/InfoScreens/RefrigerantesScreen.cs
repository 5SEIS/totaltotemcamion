using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefrigerantesScreen : InfoScreen
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
        prodButtons[3].image.sprite = prodName == "D" ? btnOnSprite : btnOffSprite;
        _myAnim.SetBool("ProdA", prodName == "A");
        _myAnim.SetBool("ProdB", prodName == "B");
        _myAnim.SetBool("ProdC", prodName == "C");
        _myAnim.SetBool("ProdD", prodName == "D");
    }

    public override void DisableScreen()
    {
        base.DisableScreen();
        prodButtons[0].image.sprite = btnOnSprite;
        prodButtons[1].image.sprite = btnOnSprite;
        prodButtons[2].image.sprite = btnOnSprite;
        prodButtons[3].image.sprite = btnOnSprite;
        _myAnim.SetBool("ProdA", false);
        _myAnim.SetBool("ProdB", false);
        _myAnim.SetBool("ProdC", false);
        _myAnim.SetBool("ProdD", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
