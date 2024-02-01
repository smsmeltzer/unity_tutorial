using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    private Vector3 myStartPosition;

    private SphereCollider myCollider;
    private MeshRenderer myRenderer;
    private AudioSource myAudio;

    private UIManager myUIManager;

    // Start is called before the first frame update
    void Start()
    {
        myStartPosition = transform.position;
        myAudio = GetComponent<AudioSource>();
        myRenderer = GetComponent<MeshRenderer>();
        myCollider = GetComponent<SphereCollider>();

        }

    // Update is called once per frame
    void Update()
    {
        transform.position = myStartPosition + new Vector3(0, Mathf.Sin(Time.time)/10, 0);
        transform.Rotate(Vector3.up * 50 * Time.deltaTime, Space.Self);
    }

    private void OnCollisionEnter(Collision collision)
    {
        myAudio.Play();
        myRenderer.enabled = false;
        myCollider.enabled = false;

        UIManager.addScore(1);
    }

}
