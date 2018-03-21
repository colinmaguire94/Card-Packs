using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCardManager : MonoBehaviour {

    public enum rarity { NONE, BASIC, COMMON, UNCOMMON, RARE, EPIC };
    ImportCards cards = new ImportCards();
    public GameObject cardGO;


    // Use this for initialization
    IEnumerator Start () {
        Debug.Log(cards.LoadCards());
        for (int i = 0; i < 5; i++)
        {
            int rand = Random.Range(1, 1000);
            if (rand <= 350)
            {
                int rand2 = Random.Range(0, cards.cards.Basic.Length - 1);
                WWW www = new WWW(cards.cards.Basic[rand2].cardArt);
                yield return www;
                GameObject card = Instantiate(cardGO);
                card.transform.position = new Vector3(card.transform.position.x + (1.0f * i), card.transform.position.y, card.transform.position.z + 3.0f);
                card.GetComponent<Renderer>().material.mainTexture = www.texture;
                Debug.Log("Basic");
            }
            else if (rand <= 600)
            {
                int rand2 = Random.Range(0, cards.cards.Common.Length - 1);
                WWW www = new WWW(cards.cards.Common[rand2].cardArt);
                yield return www;
                GameObject card = Instantiate(cardGO);
                card.transform.position = new Vector3(card.transform.position.x + (1.0f * i), card.transform.position.y, card.transform.position.z + 3.0f);
                card.GetComponent<Renderer>().material.mainTexture = www.texture;
                Debug.Log("Common");
            }
            else if (rand <= 800)
            {
                int rand2 = Random.Range(0, cards.cards.Uncommon.Length - 1);
                WWW www = new WWW(cards.cards.Uncommon[rand2].cardArt);
                yield return www;
                GameObject card = Instantiate(cardGO);
                card.transform.position = new Vector3(card.transform.position.x + (1.0f * i), card.transform.position.y, card.transform.position.z + 3.0f);
                card.GetComponent<Renderer>().material.mainTexture = www.texture;
                Debug.Log("Uncommon");
            }
            else if (rand <= 950)
            {
                int rand2 = Random.Range(0, cards.cards.Rare.Length - 1);
                WWW www = new WWW(cards.cards.Rare[rand2].cardArt);
                yield return www;
                GameObject card = Instantiate(cardGO);
                card.transform.position = new Vector3(card.transform.position.x + (1.0f * i), card.transform.position.y, card.transform.position.z + 3.0f);
                
                card.GetComponent<Renderer>().material.mainTexture = www.texture;
                Debug.Log("Rare");
            }
            else
            {
                int rand2 = Random.Range(0, cards.cards.Epic.Length - 1);
                WWW www = new WWW(cards.cards.Epic[rand2].cardArt);
                yield return www;
                GameObject card = Instantiate(cardGO);
                card.transform.position = new Vector3(card.transform.position.x + (1.0f * i), card.transform.position.y, card.transform.position.z + 3.0f);
                card.GetComponent<Renderer>().material.mainTexture = www.texture;
                Debug.Log("Epic");
            }
        }
        yield return null;
    }

	// Update is called once per frame
	void Update () {
       
	}
}
