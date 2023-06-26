using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QRCodeManager : MonoBehaviour
{
    public GameObject qrCodeScannedAnim;
    private GameObject qrObj;

    // Start is called before the first frame update
    void Start()
    {
        qrCodeScannedAnim.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        qrObj = GameObject.FindGameObjectWithTag("QROBJ");
        if(qrObj != null)
        {
            qrCodeScannedAnim.SetActive(true);
        }
    }

    public void GoBack()
    {
        SceneManager.LoadScene("MenuLogin");
    }
}
