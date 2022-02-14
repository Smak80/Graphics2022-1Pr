namespace Graphics2022_1Pr
{
    public class Painter
    {
        private int circleCount = 1;
        private Random r;

        public int CircleCount
        {
            get => circleCount;
            set
            {
                circleCount = value switch
                {
                    <= 0 => 1,
                    >= 1 and <= 15 => value,
                    >15 => 15
                };
            }
        }

        public Painter(int circleCount)
        {
            CircleCount = circleCount;
            r = new Random();
        }
        public void Paint(Graphics g)
        {
            Pen p = new Pen(Color.Blue);
            for (int i = 0; i < CircleCount; i++)
            {
                var sz = r.Next(30, 300);
                var x = r.Next((int)g.VisibleClipBounds.Width-sz-1);
                var y = r.Next((int)g.VisibleClipBounds.Height-sz-1);
                g.DrawEllipse(p, x, y, sz, sz);
            }
            
        }
    }
}
