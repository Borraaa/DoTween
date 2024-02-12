using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform hedefPoz;
    public GameObject kup;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //küp objesi (x,y,z) scale i 3 saniye içinde (3,3,3) olacak þekilde büyüyecek. setloops sayesinde eski haline geri donecek.

            //kup.transform.DOScale(Vector3.one * 3, 3).SetLoops(2, LoopType.Yoyo);

            //--------------------------------------------------------------------------------------------------

            //objenin kendi ekseni etrafýnda 180 derece döner.

            //kup.transform.DORotate(new Vector3(0, 90, 0), 4, RotateMode.WorldAxisAdd);

            //---------------------------------------------------------------------------------------------------

            //küp hedef objenin pozisyonuna 2 kere gidip gelir.

            //kup.transform.DOMove(hedefPoz.position, 3).SetLoops(4, LoopType.Yoyo);

            //----------------------------------------------------------------------------------------------------

            //küp hedef pozisyona 2 saniyede gitsin, bize 90derece dönsün. scale ý 3 olsun.

            /*kup.transform.DOMove(hedefPoz.position, 2).OnComplete(
                ()=> {
                    kup.transform.DORotate(new Vector3(0, 90, 0), 4, RotateMode.WorldAxisAdd).OnComplete(() =>
                    {
                        kup.transform.DOScale(Vector3.one * 3, 3).SetLoops(2, LoopType.Yoyo);
                    });
                });*/
            
        }

    }
}
