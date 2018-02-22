using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    const int TOTAL_VALE_CARDS = 18;
    const int PLAYER_DECK_SIZE = 20;

    //Table Fields
    Player[] players; //Also contains Player order
    int totalPlayers;

    List<ValeCard> ValeCardTier_1;
    List<ValeCard> ValeCardTier_2;

    List<AdvancementCard> AdvancementsLevel_1;
    List<AdvancementCard> AdvancementsLevel_2;
    List<AdvancementCard> AdvancementsLevel_3;

    List<AdvancementCard> FertileSoils;

    int victoryPoints;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
