import System.IO
import Data.List (sort, sortBy, groupBy, group)
import Data.Function (on)
import Data.Ord (comparing)

main :: IO ()
main = do
    contents <- lines <$> readFile "data/p054_poker.txt"    
    let games = map parseHands contents
        winners = map decideWinner games
    print $ zip games winners
    

data Player = Undecided | Player1 | Player2
              deriving (Show, Eq)

data Rank = Two | Three | Four | Five | Six | Seven | Eight | Nine | Ten | Jack | Queen | King | Ace
            deriving (Show, Eq, Ord, Enum)

data Suit = Spade | Heart | Club | Diamond
            deriving (Show, Eq)

data Card = Card { raw :: String
                 , rank :: Rank
                 , suit :: Suit
                 } deriving (Show)

data HandType = HighCard | OnePair | TwoPairs | ThreeOfAKind | Straight | Flush | FullHouse | FourOfAKind | StraightFlush | RoyalFlush
                 deriving (Show, Eq, Ord)

data Hand = Hand { cards :: [Card]
                 , highCards :: [Rank]
                 , handType :: HandType
                 } deriving (Show)

type HighCards = [Rank]


decideWinner :: (Hand, Hand) -> Player
decideWinner (p1,p2)
    | handType p1 > handType p2 = Player1
    | handType p1 < handType p2 = Player2
    | otherwise                 = compareHighCards
    where
        compareHighCards
            | head (highCards p1) > head (highCards p2) = Player1
            | head (highCards p1) < head (highCards p2) = Player2
            | otherwise                                 = Undecided


parseHands :: String -> (Hand, Hand)
parseHands cs = (Hand { cards = _cs1,
                        highCards = _highCards1,
                        handType = _handType1},
                 Hand { cards = _cs2,
                        highCards = _highCards2,
                        handType = _handType2 })
    where
        _cs1 = map parseCard $ take 5 . words $ cs
        _cs2 = map parseCard $ take 5 . drop 5 . words $ cs
        (_handType1, _highCards1) = parseHandType _cs1
        (_handType2, _highCards2) = parseHandType _cs2


parseHandType :: [Card] -> (HandType, HighCards)
parseHandType cs
    | minimum ranks == Ten && isStraight && isFlush = (RoyalFlush, highCards)
    | isStraight && isFlush                         = (StraightFlush, highCards)
    | 4 `elem` pairs                                = (FourOfAKind, pairHighCards)
    | 2 `elem` pairs && 3 `elem` pairs              = (FullHouse, pairHighCards)
    | isFlush                                       = (Flush, highCards)
    | isStraight                                    = (Straight, highCards)
    | 3 `elem` pairs                                = (ThreeOfAKind, pairHighCards)
    | 2 `elem` map length (group pairs)             = (TwoPairs, pairHighCards)
    | 2 `elem` pairs                                = (OnePair, pairHighCards)
    | otherwise                                     = (HighCard, highCards)
    where
        ranks = map rank cs
        suits = map suit cs
        isStraight = take 5 [(minimum ranks)..] == ranks
        isFlush = all (== head suits) suits
        highCards = reverse . sort $ ranks
        pairHighCards = concat $ filter (\list -> length list > 1) $ group ranks
        pairs = map length $ group ranks


parseCard :: String -> Card
parseCard s = Card { raw=s, rank=parseRank $ head s, suit=parseSuit $ last s }
    where
        parseRank r
            | r == '2' = Two
            | r == '3' = Three
            | r == '4' = Four
            | r == '5' = Five
            | r == '6' = Six
            | r == '7' = Seven
            | r == '8' = Eight
            | r == '9' = Nine
            | r == 'T' = Ten
            | r == 'J' = Jack
            | r == 'Q' = Queen
            | r == 'K' = King
            | r == 'A' = Ace
        parseSuit s
            | s == 'S' = Spade
            | s == 'H' = Heart
            | s == 'C' = Club
            | s == 'D' = Diamond
