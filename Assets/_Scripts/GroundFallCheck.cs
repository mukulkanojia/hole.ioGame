using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFallCheck : MonoBehaviour{
    
    [SerializeField] private Hole hole;
    [SerializeField] private GameObject _counterCheck;
    private void OnTriggerEnter(Collider coli){
        coli.gameObject.SetActive(false);
        hole.IncreaseScore(1);
        StartCoroutine(counterCheck());
    }

    IEnumerator counterCheck()
    {
        _counterCheck.SetActive(true);

        yield return new WaitForSeconds(0.5f);

        _counterCheck.SetActive(false);
    }
}
