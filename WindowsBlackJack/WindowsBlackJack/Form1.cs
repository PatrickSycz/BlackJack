using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsBlackJack
{
    public partial class MainForm : Form
    {
        public Deck Player, Dealer, CardDeck;
        public Card BackgroundCard;
        public List<Card> PlayerInProgress, DealerInProgress;
        int PlayerX, PlayerY, DealerOffset;
        float PlayerXOffset, PlayerYOffset;
        bool DealingToPlayer, DealingToDealer = false;
        public MainForm()
        {
            InitializeComponent();
            Player = new Deck("Player");
            Dealer = new Deck("Dealer");
            CardDeck = new Deck("Deck");
            BackgroundCard = new Card();
            PlayerInProgress = new List<Card>();
            DealerInProgress = new List<Card>();
            BackgroundCard.SetImage("BackgroundBlue.png");
            PlayerX = 200;
            PlayerY = 300;
            PlayerXOffset = 0;
            PlayerYOffset = 0;
            DealerOffset = 0;
        }
        private void DealToPlayer()
        {
            DealingToPlayer = true;
            Card c = new Card();
            PlayerInProgress.Add(c);
            c = CardDeck.GetCardList().FirstOrDefault();
            if (c != null)
            {
                c.SetX(PlayerX);
                c.SetY(PlayerY);
                PlayerX += 75;
                Player.AddCard(c);

                CardDeck.RemoveTopCard();
            }
            
        }
        private void DealToDealer()
        {
            DealingToDealer = true;
            DealerInProgress.Add(CardDeck.GetCardList().First());
            Dealer.AddCard(CardDeck.GetCardList());
            CardDeck.RemoveTopCard();
        }
        protected override void WndProc(ref Message m)
        {
            //Refresh();
            base.WndProc(ref m);
        }
        private void HitButton_Click(object sender, EventArgs e)
        {
            DealToPlayer();
            if (Player.GetCardList().Count > 4)
                HitButton.Enabled = false;
            ScoreText.Text = Player.GetTotalHandValue().ToString();
            //this.Refresh();
        }

        private void PassButton_Click(object sender, EventArgs e)
        {
            HitButton.Visible = false;
            HitButton.Enabled = false;
            PassButton.Visible = false;
            PassButton.Enabled = false;
            StartButton.Enabled = true;
            StartButton.Visible = true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            int x = 20;
            int y = 100;
            if (Player.GetCardList().Count > 0)
            {
                e.Graphics.DrawImage(Player.GetCardList().Last().GetImage(), x, y);
            }
            DrawPlayerHand(e);
            DrawDeck(e);
            DrawDealerHand(e);
            if (DealingToPlayer)
                PlayerDealingAnimation(e);
            if (DealingToDealer)
                DealerDealingAnimation(e);

        }

        private void DealerDealingAnimation(PaintEventArgs e)
        {
            int offset = 0;
            int ImageWidth = BackgroundCard.GetImage().Width;
            foreach (Card c in DealerInProgress)
            {
                e.Graphics.DrawImage(BackgroundCard.GetImage(), offset + DealerOffset, 0);
                offset += ImageWidth;
            }
            DealerOffset += 10;
            if (DealerOffset > 124)
            {
                DealerOffset = 0;
                DealingToDealer = false;
                DealerInProgress = new List<Card>();
            }
        }

        private void PlayerDealingAnimation(PaintEventArgs e)
        {
            int offset = 0;
            int ImageWidth = BackgroundCard.GetImage().Width;
            foreach (Card c in PlayerInProgress)
            {
                e.Graphics.DrawImage(BackgroundCard.GetImage(), PlayerXOffset - offset, PlayerYOffset);
                offset += ImageWidth;
            }
            PlayerXOffset += 10.0F;
            PlayerYOffset += (float)PlayerY/(float)(PlayerX-75) * 10.0F;
            if (PlayerXOffset > PlayerX-75)
            {
                PlayerXOffset = 0;
                PlayerYOffset = 0;
                DealingToPlayer = false;
                PlayerInProgress = new List<Card>();
            }
        }
        private void DrawPlayerHand(PaintEventArgs e)
        {
            List<Card> CardList;
            if (DealingToPlayer)
                CardList = Player.GetCardList().GetRange(0, Player.GetCardList().Count - PlayerInProgress.Count);
            else
                CardList = Player.GetCardList();
            foreach (Card card in CardList)
            {
                e.Graphics.DrawImage(card.GetImage(), card.GetX(), card.GetY());
            }
        }
        private void DrawDeck(PaintEventArgs e)
        {
            float offset = 0;
            for (int i = 0; i < (CardDeck.GetCardList().Count/4); i++)
            {
                e.Graphics.DrawImage(BackgroundCard.GetImage() , offset, 0);
                offset += 0.70F;
            }
        }
        private void DrawDealerHand(PaintEventArgs e)
        {
            List<Card> CardList;
            if (DealingToDealer)
                CardList = Dealer.GetCardList().GetRange(0, Dealer.GetCardList().Count - DealerInProgress.Count);
            else
                CardList = Dealer.GetCardList();
            int offset = 125;
            if(CardList.Count > 0)
                e.Graphics.DrawImage(CardList.First().GetImage(), offset, 0);
            offset += 75;
            if (CardList.Count > 1)
            {
                for (int i = 0; i < CardList.Count - 1; i++)
                {
                    e.Graphics.DrawImage(BackgroundCard.GetImage(), offset, 0);
                    offset += 75;
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            CardDeck = new Deck("Deck");
            Player = new Deck("Player");
            Dealer = new Deck("Dealer");
            PlayerX = 200;
            DealerOffset = 0;
            DealToDealer();
            DealToPlayer();
            DealToDealer();
            DealToPlayer();
            StartButton.Enabled = false;
            StartButton.Visible = false;
            HitButton.Enabled = true;
            HitButton.Visible = true;
            PassButton.Enabled = true;
            PassButton.Visible = true;
            ScoreText.Text = Player.GetTotalHandValue().ToString();
        }
    }
}
