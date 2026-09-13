namespace ChessLogic
{
    public class Counting
    {
        private readonly Dictionary<PieceType, int> whitecount = new();
        private readonly Dictionary<PieceType, int> blackcount = new();

        public int TotalCount { get; private set; }

        public Counting()
        {
           foreach (PieceType type in Enum.GetValues(typeof(PieceType)))
            {
                whitecount[type] = 0;
                blackcount[type] = 0;
            }
        }

        public void Increment(Player color, PieceType type)
        {
            if (color == Player.White)
            {
                whitecount[type]++;
            }
            else if (color == Player.Black)
            {
                blackcount[type]++;
            }

            TotalCount++;
        }

        public int White(PieceType type)
        {
            return whitecount[type];
        }

        public int Black(PieceType type)
        {
            return blackcount[type];
        }
    }
}
