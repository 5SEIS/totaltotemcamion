using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AditivosScreen : InfoScreen
{
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }

    public override void SetProduct(bool view)
    {
        base.SetProduct(view);
        _myAnim.SetBool("Product",view);
    }

    public override void DisableScreen()
    {
        base.DisableScreen();
        _myAnim.SetBool("Product", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
