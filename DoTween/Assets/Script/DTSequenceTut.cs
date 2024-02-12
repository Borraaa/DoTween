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
        // 90 dereceye gelene kadar ka� kere update edilmi� oldu�unu g�sterir.

        //int updateCount = 0;
        //objs[0].DORotate(new Vector3(-90, 0, 0), 1f).OnUpdate(() =>
        //{
        //    Debug.Log("Update: " + updateCount);
        //    updateCount++;
        //});

        //---------------------------------------------------------------------------------------------------


        // oyun �al��t���nda 3 saniya sonra 90 derece d�necek.

        //objs[0].DORotate(new Vector3(-90, 0, 0), 1f).SetDelay(3f);

        //------------------------------------------------------------------------------------------------------


        // OnComplate ile b�yle yap�l�r.

        //objs[0].DOMove(objs[0].transform.position + objs[0].transform.forward * 10, 1).OnComplete(() =>
        //{
        //    objs[1].DOMove(objs[1].transform.position + objs[1].transform.forward * 10, 1).OnComplete(() =>
        //    {
        //        objs[2].DOMove(objs[2].transform.position + objs[2].transform.forward * 10, 1);
        //    });
        //});


        //--------------------------------------------------------------------------------------------------------------------

        // listede 300 objemiz olsun OnComplate ile cok uzun s�rece�i i�in b�yle bir sistemle yapmak daha k�sa s�recek.

        //var sequence = DOTween.Sequence();

        //foreach(Transform obj in objs)
        //{
        //    sequence.Append(obj.DOMove(obj.transform.position + obj.transform.forward * 10, 1));
        //}

        //-------------------------------------------------------------------------------------------------

        //oyunu ba�latt���n�zda obje 0 kendi etraf�nda d�ner. OnKill() sayesinde space tusua bas�ld��� anda obje 0
        //kendi etraf�nda d�nmeyi b�rak�r 1. obje ye ge�ip scale ini 2 yapmaya ba�lar. test etmek i�in Update i�indeki
        // DOKill() i a��n.

        //objs[0].DORotate(new Vector3(-90, 0, 0), 1f).SetLoops(-1, LoopType.Incremental).OnKill(() =>
        //{
        //    objs[1].DOScale(new Vector3(2, 2, 2), 1f);
        //});



    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // easgs.net sitesinden Ease komutlar�n� se�ip istedi�inizi koyabilirsiniz. ama bu y�ntemler unity �zerinden hangisini 
            //istedi�imizi se�ebiliriz. bize b�t�n listeyi verir.

            //objs[0].transform.position = new Vector3(10f, objs[0].transform.position.y, objs[0].transform.position.z);
            //objs[0].DOMoveZ(10f, 1f).SetEase(eases);

            //objs[0].DOKill();

            
        }
        
    }
}
