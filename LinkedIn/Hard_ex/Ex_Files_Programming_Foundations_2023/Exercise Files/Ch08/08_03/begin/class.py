import random

class Card:
    """Represents a playing card."""
    def __init__(self, suit, rank):
        self.suit = suit
        self.rank = rank

    def __str__(self):
        return f"{self.rank} of {self.suit}"

class Deck:
    """Represents a deck of cards."""
    def __init__(self):
        self.cards = [Card(suit, rank) for suit in ['Hearts', 'Diamonds', 'Clubs', 'Spades']
                      for rank in ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'Jack', 'Queen', 'King', 'Ace']]
        random.shuffle(self.cards)

    def deal(self):
        return self.cards.pop()

class PokerGame:
    """Simulates a game of Texas Hold'em poker."""
    def __init__(self, buy_in):
        self.buy_in = buy_in
        self.vik_balance = buy_in

    def play_round(self):
        if self.vik_balance < self.buy_in:
            print("Vik does not have enough balance to continue playing.")
            return False
        
        # Vik buys in for the round
        self.vik_balance -= self.buy_in
        print(f"Vik buys in for ${self.buy_in}. Current balance: ${self.vik_balance}")

        # Create and shuffle the deck
        deck = Deck()
        
        # Deal community cards (Flop, Turn, River)
        community_cards = [deck.deal() for _ in range(5)]
        
        # Deal Vik's hand (2 hole cards)
        vik_hand = [deck.deal(), deck.deal()]

        print("\nCommunity Cards:")
        for card in community_cards:
            print(card)

        print("\nVik's Hand:")
        for card in vik_hand:
            print(card)

        # Randomly determine if Vik wins or loses for simplicity
        outcome = random.choice(['win', 'lose'])
        if outcome == 'win':
            winnings = random.randint(50, 150)  # Vik wins between $50 to $150
            self.vik_balance += winnings
            print(f"\nVik won ${winnings}! Current balance: ${self.vik_balance}")
        else:
            print(f"\nVik lost ${self.buy_in}. Current balance: ${self.vik_balance}")

        return True

def simulate_poker_games(num_rounds, buy_in):
    game = PokerGame(buy_in)
    
    for round_number in range(num_rounds):
        print(f"\n--- Round {round_number + 1} ---")
        if not game.play_round():
            break

# Simulate 10 rounds of poker for Vik
simulate_poker_games(num_rounds=10, buy_in=30)