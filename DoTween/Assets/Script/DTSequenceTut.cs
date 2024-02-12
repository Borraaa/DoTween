using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DTSequenceTut : MonoBehaviour
{
    [SerializeField] private List<Transform> objs;
    public Ease eases;
    void Start()
    {
        // 90 dereceye gelene kadar kaç kere update edilmiþ olduðunu gösterir.

        //int updateCount = 0;
        //objs[0].DORotate(new Vector3(-90, 0, 0), 1f).OnUpdate(() =>
        //{
        //    Debug.Log("Update: " + updateCount);
        //    updateCount++;
        //});

        //---------------------------------------------------------------------------------------------------


        // oyun çalýþtýðýnda 3 saniya sonra 90 derece dönecek.

        //objs[0].DORotate(new Vector3(-90, 0, 0), 1f).SetDelay(3f);

        //------------------------------------------------------------------------------------------------------


        // OnComplate ile böyle yapýlýr.

        //objs[0].DOMove(objs[0].transform.position + objs[0].transform.forward * 10, 1).OnComplete(() =>
        //{
        //    objs[1].DOMove(objs[1].transform.position + objs[1].transform.forward * 10, 1).OnComplete(() =>
        //    {
        //        objs[2].DOMove(objs[2].transform.position + objs[2].transform.forward * 10, 1);
        //    });
        //});


        //--------------------------------------------------------------------------------------------------------------------

        // listede 300 objemiz olsun OnComplate ile cok uzun süreceði için böyle bir sistemle yapmak daha kýsa sürecek.

        //var sequence = DOTween.Sequence();

        //foreach(Transform obj in objs)
        //{
        //    sequence.Append(obj.DOMove(obj.transform.position + obj.transform.forward * 10, 1));
        //}

        //-------------------------------------------------------------------------------------------------

        //oyunu baþlattýðýnýzda obje 0 kendi etrafýnda döner. OnKill() sayesinde space tusua basýldýðý anda obje 0
        //kendi etrafýnda dönmeyi býrakýr 1. obje ye geçip scale ini 2 yapmaya baþlar. test etmek için Update içindeki
        // DOKill() i açýn.

        //objs[0].DORotate(new Vector3(-90, 0, 0), 1f).SetLoops(-1, LoopType.Incremental).OnKill(() =>
        //{
        //    objs[1].DOScale(new Vector3(2, 2, 2), 1f);
        //});



    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // easgs.net sitesinden Ease komutlarýný seçip istediðinizi koyabilirsiniz. ama bu yöntemler unity üzerinden hangisini 
            //istediðimizi seçebiliriz. bize bütün listeyi verir.

            //objs[0].transform.position = new Vector3(10f, objs[0].transform.position.y, objs[0].transform.position.z);
            //objs[0].DOMoveZ(10f, 1f).SetEase(eases);

            //objs[0].DOKill();

            
        }
        
    }
}
