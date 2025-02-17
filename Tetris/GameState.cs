namespace Tetris
{
    public class GameState
    {
        private Block currentBlock;

        public Block currentBlock
        {
            get => currentBlock;
            private set
            {
                currentBlock = value;
                currentBlock.reset();
            }
        }

    }
}
