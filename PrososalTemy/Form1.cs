using System;

namespace PrososalTemy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            int x = 300;
            int y = 300;

            List<command> cmds = new List<command>()
            {
                new command("left", "90"),
                new command("forward","164"),
                new command("left", "90"),
                new command("forward", "140"),
                new command("left", "90"),
                new command("forward", "164"),
                new command("left", "90"),
                new command("forward", "140"),
                new command("left", "180"),
                new command("forward", "140"),
                new command("right", "55"),
                new command("forward", "100"),
                new command("right", "69"),
                new command("forward", "100"),
                new command("right", "56"),
                new command("forward", "140"),
                new command("right" ,"88"),
                new command("forward", "60"),
                new command("right", "92"),
                new command("forward", "90"),
                new command("left", "92"),
                new command("forward", "40"),
                new command("left", "88"),
                new command("forward", "90")
            };
            double a = 0;
            int forward = 100;
            for (int i = 0; i < cmds.Count; i++)
            {
                Point point1 = new(x, y);
                if (cmds[i].key == "right") 
                {
                    a += double.Parse(cmds[i].value);
                }
                if (cmds[i].key == "left")
                {
                    a += double.Parse(cmds[i].value);
                }
                if (cmds[i].key == "forward")
                {
                    forward += int.Parse(cmds[i].value);
                }
                y += (int)(forward * Math.Cos(a / 180 * Math.PI));
                x += (int)(forward * Math.Sin(a / 180 * Math.PI));
                Point point2 = new(x, y);
                e.Graphics.DrawLine(pen, point1, point2);
                forward = 0;
            }
        }
    }
    public class command
    {
        public string key;
        public string value;
        public command(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }

}
