using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace TopTrumps {
    public abstract class Deck : Microsoft.Xna.Framework.GameComponent {
        private String _deckName;
        private Stack<Card> _cards;
        private Texture2D cardTexture;

        public Deck(Game game, String name, Stack<Card> cards, Texture2D cardTexture)
            : base(game)
        {
            _deckName = name;
            _cards = cards;
            this.cardTexture = cardTexture;
        }

        public abstract override void Initialize();

        public abstract void LoadContent(ContentManager c);

        public abstract override void Update(GameTime gameTime);

        public Stack<Card> cards {
            get {
                return _cards;
            }
        }

        public String deckName {
            get {
                return _deckName;
            }
        }
    }
}
