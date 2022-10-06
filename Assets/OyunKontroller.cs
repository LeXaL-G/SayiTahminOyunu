using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontroller : MonoBehaviour
{
    int tahmin;
    int minsayi = 1;
    int maxsayi = 100;
    bool oyunBasladi = false;
    bool oyunBitti = false;
    void Start()
    {
        print("Benimle oyun oynamak istermisin?(E/H)");
    }

    void Update()
    {
        if (!oyunBasladi)
        {
            if(Input.GetKeyDown(KeyCode.E))
                print("Yaşasın! Şimdi 1-100 arası bir sayı tahmin et ve Enter tuşuna bas.");
            else if(Input.GetKeyDown(KeyCode.H))
                print("Sen Bilirsin.");
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Kontrol();
                oyunBasladi = true;
            }
        }
        else if (!oyunBitti)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minsayi = tahmin;
                Kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxsayi = tahmin;
                Kontrol();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Yaşasıın! Sonunda buldum.");
                oyunBitti = true;
            }
                
        }
    }

    void Kontrol()
    {
        tahmin = (maxsayi + minsayi) / 2;
        print($"Tahmin ettiğin sayı {tahmin} se 'space' tuşuna bas, tuttuğun sayı daha büyükse yukarı ok tuşu küçükse aşşağı ok tuşuna bas.");
    }
}
