namespace BinaryTree
{
    public class TreeBreadth
    {
        public int Left { get; set; }
        public int Right { get; set; }

        public override string ToString()
        {
            return string.Format("Left: {0} Right: {1}", this.Left, this.Right);
        }

        public override bool Equals(object obj)
        {
            var toCompare = obj as TreeBreadth;
            if (toCompare == null) return false;

            if (this.Left == toCompare.Left && this.Right == toCompare.Right)
            {
                return true;
            }

            return false;
        }

        public int GetHashCode(TreeBreadth obj)
        {
            throw new System.NotImplementedException();
        }
    }
}