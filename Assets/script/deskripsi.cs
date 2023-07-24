using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deskripsi : MonoBehaviour
{
    [Header("Deskripsi")]
    public ar[] tr;
    public string[] nama;
    [TextArea]
    public string[] deskripsii;
    [Header("UI Deskripsi")]
    public Text txtnama;
    public Text txtdesk;
    public GameObject goNama;
    public GameObject godes;
    public GameObject penanda;
    public GameObject key;



    public bool[] cekMarker;
    int countMarker;
    // Start is called before the first frame update
    void Start()
    {
        cekMarker = new bool[tr.Length];
    }
    
    // Update is called once per frame
    void Update()
    {
        DeskripsiPanel();
        for (int i=0; i<tr.Length; i++)
        {
            if (tr[i].GetMarker())
            {
                txtnama.text = nama[i];
                txtdesk.text = deskripsii[i];

                if (!cekMarker[i])
                {
                    countMarker++;
                    cekMarker[i] = true;
                    goNama.SetActive(true);
                    godes.SetActive(true);
                    penanda.SetActive(false);
                    key.SetActive(false);
                }
            }
            else
            {
                if (cekMarker[i])
                {
                    countMarker--;
                    cekMarker[i] = false;
                    goNama.SetActive(false);
                    godes.SetActive(false);
                    penanda.SetActive(true);
                    key.SetActive(true);
                }
            }
        }
        
    }
    private void DeskripsiPanel()
    {
        if(countMarker == 0)
        {
            goNama.SetActive(false);
            godes.SetActive(false);
            penanda.SetActive(true);
            key.SetActive(true);
        }
        else
        {
            goNama.SetActive(true);
            godes.SetActive(true);
            penanda.SetActive(false);
            key.SetActive(false);
        }
    }
}
