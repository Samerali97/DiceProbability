/*
 * Name : Samer Ali
 * NetID : U33047132
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            //Receive seed value from text box (user input)
            int.TryParse(Textbox_Seed.Text, out int seed);

            //Create Dice Objects
            ADie dice1 = new ADie();
            ADie dice2 = new ADie(seed);

            //Receive Number of Rolls from text box (user input)
            int.TryParse(Textbox_NumberOfRolls.Text, out int numberOfRolls);

            //Initialize count values of each dice object to be equal to 0
            for(int i = 0; i <= 6; i++){
                dice1.diceChartCount.Add(0);
                dice2.diceChartCount.Add(0);
            }

            //Initialize Lists to hold Sum and product of Dice Values
            List<int> diceSumCount = new List<int>(13);
            List<int> diceProductCount = new List<int>(37);

            //Initialize Sum Count List to be equal to 0
            for (int i = 0; i <= 13; i++) { 
                diceSumCount.Add(0);
            }

            //Initialize Product Count List to be equal to 0
            for (int i = 0; i <= 37; i++){
                diceProductCount.Add(0);
            }

            //Roll the dice the # of times specified by the user
            for (int i = 0; i < numberOfRolls; i++) { 
                int diceOneRoll, diceTwoRoll, amountOne, amountTwo;               

                diceOneRoll = dice1; //Roll dice one
                amountOne = dice1.diceChartCount[diceOneRoll]; //Retrieve Count for that value
                diceTwoRoll = dice2; //Roll dice two
                amountTwo = dice2.diceChartCount[diceTwoRoll]; //Retrieve Count for that value

                //Update Both Charts for dice One and Two
                Chart_Dice_One.Series[0].Points.AddXY(diceOneRoll, amountOne);
                Chart_Dice_One.Update();
                Chart_Dice_Two.Series[0].Points.AddXY(diceTwoRoll, amountTwo);
                Chart_Dice_Two.Update();

                //Summation of both dice rolls, and update count for sum list
                int sum = dice1 + dice2;
                int amountSum = diceSumCount[sum] += 1; 

                //Update Summation Chart
                Chart_Dice_Sum.Series[0].Points.AddXY(sum, amountSum);
                Chart_Dice_Sum.Update();

                //Product of both dice rolls, and update count for product list
                int product = dice1 * dice2;
                int amountProduct = diceProductCount[product] += 1;

                //Update Product Chart
                Chart_Dice_Product.Series[0].Points.AddXY(product, amountProduct);
                Chart_Dice_Product.Update();
            }
        }

        private void Button_Toss_Click(object sender, EventArgs e)
        {
            //Create new Coin Object
            Coin coin = new Coin();

            //Initialize history to be equal to 0'
            for(int i = 0; i < 2; i++){
                coin.tossHistory.Add(0);
            }

            coin.Toss(); //Toss Coin
            string result = coin; //Retrieve result of tossing coin and display
            Textbox_Toss_Result.Text = result;
        }

        private void Button_Toss_Simulate_Click(object sender, EventArgs e)
        {
            //Create new coin object
            Coin coin = new Coin();

            //Initialize history to be equal to 0's
            for (int i = 0; i < 2; i++) { 
                coin.tossHistory.Add(0);
            }

            //Receive number of tosses from user (user input)
            int.TryParse(Textbox_NumberOfRolls.Text, out int amountOfTosses);

            for(int i = 0; i < amountOfTosses; i++) { 
                //Toss coin
                coin.Toss();

                //Retrieve both face and value of coin (Heads/0 & Tails/1)
                string result = coin;
                int faceValue = coin;

                //Retrieve amount of specific face, and update chart accordingly
                int amount = coin.tossHistory[faceValue];
                Chart_Coin_Tosses.Series[0].Points.AddXY(faceValue, amount);
                Chart_Coin_Tosses.Update();
            }
        }

        //Used for 'Button_Draw_Card_Click', in which uses the same deck each time card is asked to be chosen
        aDeckOfCards deck_For_DrawOneCard = new aDeckOfCards(); //Global Deck of Cards     
        int cardCounter_For_DrawOneCard = 52; //Total Card Counter
        private void Button_Draw_Card_Click(object sender, EventArgs e)
        {

            //Draws card from shuffled deck (initialized lines 148-150)           
            ACard tempCard = deck_For_DrawOneCard;
            Textbox_Draw_OneCard.Text = tempCard.ToString(); //Writes card to textbot

            cardCounter_For_DrawOneCard--;//Decrement amount of cards left
            Textbox_Number_Cards_Left.Text = cardCounter_For_DrawOneCard.ToString(); //Writes amount of cards left

            //If all cards have been played, re-establish deck of cards and card counter
            if (cardCounter_For_DrawOneCard == 0){
                deck_For_DrawOneCard.initializeDeck();
                deck_For_DrawOneCard.shuffleDeck();
                cardCounter_For_DrawOneCard = 52;
            }           
        }

        //Used for 'Button_Draw_Hand_Click', in which uses the same deck each time hand is asked to be selected
        aDeckOfCards deck_DrawHand = new aDeckOfCards(); //Global deck of cards
        int cardCounter_For_DrawHand = 52; //Total Card Counter
        private void Button_Draw_Hand_Click(object sender, EventArgs e)
        {
            //Empty List of cards
            ComboBox_Hand.Items.Clear();
            int.TryParse(Textbox_Hand_Amount.Text, out int handSize); //Retrieve amount of cards the user wants for hand

            //If user wants hand that's greater than amount of cards left, we intialize new deck of cards
            if(handSize > cardCounter_For_DrawHand){
                deck_DrawHand.initializeDeck();
                deck_DrawHand.shuffleDeck();
                cardCounter_For_DrawHand = 52;
            }

            ACard[] hand = new ACard[handSize]; //Initialize array to hold cards selected from deck

            //Store cards selected into array
            for (int i = 0; i < handSize; i++) {
                hand[i] = deck_DrawHand;
                cardCounter_For_DrawHand--;
            }

            ComboBox_Hand.Items.AddRange(hand);//Display cards in comboBox
            Textbox_Number_Cards_Left_Hand.Text = cardCounter_For_DrawHand.ToString(); //Display number of cards left in deck
        }
    }
}
public class aDeckOfCards : ARandom
{
    //Attributes of Class
    const int numberOfCardsInDeck = 52;
    public ACard[] deck;
    public int deckCounter;

    //Default Constructor for deck of cards
    public aDeckOfCards()
    {
        deck = new ACard[numberOfCardsInDeck]; //Creates array of 52 cards
        deckCounter = 51;
        int i, j;
        int count = 0;//Used to keep track within array

        //Here we initialize the deck, filling the array with every card
        for (i = 1; i < 5; i++)
        { //For each SUIT
            for (j = 1; j < 14; j++)
            {//For each FACE
                deck[count] = new ACard(i, j); //Create new card
                count++;                       //Increment index in array
            }
        }

        //Here we shuffle the deck of cards, in which the algorithm is Fisher-Yates shuffle
        for (int m = 51; m > 0; m--)
        {
            int k = rand.Next(m + 1);
            ACard temp = deck[m];
            deck[m] = deck[k];
            deck[k] = temp;
        }
    }

    //Method to initialize deck of cards
    public void initializeDeck()
    {
        int i, j;
        int count = 0;
        deckCounter = 51;
        //Here we initialize the deck, filling the array with every card
        for (i = 1; i < 5; i++) //For each SUIT
        {
            for (j = 1; j < 14; j++)//For each FACE
            {
                deck[count] = new ACard(i, j); //Create new card
                count++;                       //Increment index in array
            }
        }
    }

    //Method to shuffle deck of cards
    public void shuffleDeck()
    {
        //Here we shuffle the deck of cards, in which the algorithm is Fisher-Yates shuffle
        for (int m = 51; m > 0; m--)
        {
            int k = rand.Next(m + 1);
            ACard temp = deck[m];
            deck[m] = deck[k];
            deck[k] = temp;

        }
    }

    //Method to retrieve card from deck
    public ACard DealCard()
    {
        return deck[deckCounter--];
    }

    //Implicit operator that returns type ACard, from a deck
    public static implicit operator ACard(aDeckOfCards d)
    {
        ACard temp = new ACard();
        temp = d.DealCard();
        return temp;
    }
}
public enum SUIT{
    S = 1,
    H = 2,
    D = 3,
    C = 4
}

public enum FACES{
    ACE = 1, TWO = 2, THREE = 3, FOUR = 4, FIVE = 5, SIX = 6, SEVEN = 7, EIGHT = 8,
    NINE = 9, TEN = 10, JACK = 11, QUEEN = 12, KING = 13
}

public class ACard : ARandom
{

    //Attributes of class
    public int mySuit;
    public int myFace;

    //Standard Constructor
    public ACard()
    {
        mySuit = rand.Next(1, 4);
        myFace = rand.Next(1, 14);
    }

    //Constructor with parameters
    public ACard(int cardSuit, int cardFace)
    {
        this.mySuit = cardSuit;
        this.myFace = cardFace;
    }

    //Override ToString, which prints card format (Face - Suit)
    public override string ToString()
    {
        return Enum.GetName(typeof(FACES), myFace) + "-" + Enum.GetName(typeof(SUIT), mySuit);
    }

}

public class Coin : ARandom
{
    //Attributes of Coin
    private string face; //Visual of coin (either heads or tails)
    public List<int> tossHistory; //History of tosses for coin

    //Default Constructor
    public Coin()
    {
        this.face = "HEADS";
        this.tossHistory = new List<int>(2);
    }

    //Method to generate toss and store result within history
    public void Toss()
    {
        if (rand.Next(2) == 0)
        {
            face = "HEADS";
            tossHistory[0] += 1;
        }
        else
        {
            face = "TAILS";
            tossHistory[1] += 1;
        }
    }

    //Method to return result of toss
    public string getFace()
    {
        return face;
    }

    //Implicit declaration to return type INT (value of coin being either 1 or 0)
    public static implicit operator int(Coin tempCoin)
    {
        return tempCoin.getValue();
    }

    //Implicit declaration to return type STRING (HEADS or TAILS)
    public static implicit operator string(Coin tempCoin)
    {

        return tempCoin.getFace();
    }

    //Method to return value of face (0 or 1)
    public int getValue()
    {
        if (face == "HEADS")
            return 0;
        else
            return 1;
    }
}

public class ADie : ARandom
{
    public List<int> diceChartCount; //History of counts for this specific dice

    public ADie()
    {
        this.diceChartCount = new List<int>(7);
    }

    //Constructor with parameters (seed)
    public ADie(int tempSeed)
    {
        rand = new Random(tempSeed);
        this.diceChartCount = new List<int>(7);
    }

    //Rolls the dice, stores value in count List of dice, and returns a value between 1 and 6
    public int RollDie()
    {
        int value = rand.Next(1, 7);
        this.diceChartCount[value] += 1;
        return value;
    }

    //Implicit declaration for return of type INT
    public static implicit operator int(ADie tempDie)
    {
        return tempDie.RollDie();
    }
}

//ARandom is a base class, used for Inheritance, and contains the static member 'rand' in which
//all other classes refer to the same exact member.
public class ARandom : Random
{
    //Attributes of class
    public static Random rand; //Static Random member (Only one instance throughout program used)

    public ARandom()//Constructor
    {
        rand = new Random();
    }
    public ARandom(int tempseed)//Constructor
    {
        rand = new Random(tempseed);
    }
}
