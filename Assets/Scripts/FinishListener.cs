using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;
using System;




public class FinishListener : MonoBehaviour
{
    // Start is called before the first frame update

    private Dictionary<string, Action> keywordActions = new Dictionary<string, Action>();
    private KeywordRecognizer keywordRecognizer;

    public UIManager uiManager;
    [SerializeField] GameObject myPrefab;
    void Start()
    {
        keywordActions.Add("finish", FinishA);

        keywordRecognizer = new KeywordRecognizer(keywordActions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += OnKeywordsRecognized;
        keywordRecognizer.Start();
        uiManager = myPrefab.GetComponent<UIManager>();
    }

    private void FinishA()
    {
        if (uiManager.getScore() >=4){
            Debug.Log("Winner!");
        }
        else{
            Debug.Log("Not Enough Coins");
        }
        // Debug.Log("activated");
    }

    private void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log("Keyword: " + args.text);
        keywordActions[args.text].Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
