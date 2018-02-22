using System.Collections.Generic;

public class Player {
    string name;
    bool manaToken;
    int victoryPoints;
    int currentSpoilCount;
    int turnsTaken;

    List<ValeCard> valeCards;
    List<PlayerCard> deck;
    List<PlayerCard> discardPile;
    List<PlayerCard> hand;
}
