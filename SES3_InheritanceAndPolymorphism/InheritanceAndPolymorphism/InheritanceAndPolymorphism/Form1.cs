namespace InheritanceAndPolymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Form1_Paint");
            Graphics g = e.Graphics;
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rect(50, 50, Color.Yellow, 350,350));
            shapes.Add(new Circle(100, 100, Color.Red, 50));
            shapes.Add(new Circle(200, 200, Color.Blue, 75));
            shapes.Add(new Circle(300, 300, Color.Green, 100));
            
            foreach (Shape s in shapes)
            {
                s.draw(g);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form1_Load");
        }
    }
}
