using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EblansController : MonoBehaviour
{
    [SerializeField] int maxEblans;
    [SerializeField] List<Eblan> eblans;
    public GameObject eblanPref;

    // Start is called before the first frame update
    void Start()
    {
        DOTween.SetTweensCapacity(200,100);
        for(int i = 0; i < PlayerPrefs.GetInt("EblansCount"); i++) 
        {
            Plus(false);
        }
    }

    void Save()
    {
        PlayerPrefs.SetInt("EblansCount", eblans.Count);
        PlayerPrefs.Save();
    }

    void Plus(bool save) 
    {
        var newEblan = GameObject.Instantiate(eblanPref,transform);
        var newEblanScript = newEblan.GetComponent<Eblan>();
        
        eblans.Add(newEblanScript);
        newEblanScript.SetId(eblans.Count - 1);

        if(save)
            Save();
    }

    void Minus()
    {
        var destroyedEblan = eblans[eblans.Count - 1];

        eblans.Remove(destroyedEblan);
        Destroy(destroyedEblan.gameObject);


        Save();
    }

    public void PlusButton()
    {
        if (eblans.Count < maxEblans)
            Plus(true);
    }
    
    public void MinusButton()
    {
        if (eblans.Count > 0)
            Minus();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.KeypadMinus))
            MinusButton();
        if (Input.GetKeyDown(KeyCode.Plus) || Input.GetKeyDown(KeyCode.KeypadPlus))
            PlusButton();
    }

}
