using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WF_Slagalica
{
    public partial class Spajalica : Form
    {
        int START_POS_X = 200;
        int START_POS_Y = 39;
        int VERTICAL_SPACE = 206;// Rucno utvrdjen razmak
        int HORIZONTAL_SPACE = 165;
        int NUM_OF_TILES = 6;
        int NUM_OF_OPEN_TILES = 0;
        string DEFAULT_TILE_IMG_PATH = "C:\\Users\\jsavic\\Documents\\FaxProjects\\HCI\\WF_Slagalica\\WF_Slagalica\\assets\\default\\tile.jpg";
        PictureBox pictureBox1;
        PictureBox pictureBox2;

        List<PictureBox> pictureBoxes = new List<PictureBox>();
        Hashtable answers = new Hashtable();

        public Spajalica()
        {
            InitializeComponent();
            CreateTiles();
            AssignImagesToTiles();
        }
        private void HandleClicks(Object sender, EventArgs e)
        {
            if (NUM_OF_OPEN_TILES < 2)
            {
                PictureBox pictureBox = (PictureBox)sender;
                ShowImg(sender, e);
                NUM_OF_OPEN_TILES++;
                if (NUM_OF_OPEN_TILES == 1)
                {
                    pictureBox1 = pictureBox;
                }
                else
                {
                    pictureBox2 = pictureBox;
                }
            }
            else if(NUM_OF_OPEN_TILES == 2)
            {
                bool isCorrect=false;
                if (IsSame())
                {
                    lblScore.Text = (int.Parse(lblScore.Text)+1).ToString();
                    isCorrect = true;
                }
                else
                {
                    pictureBox1.Image = new Bitmap(DEFAULT_TILE_IMG_PATH);
                    pictureBox2.Image = new Bitmap(DEFAULT_TILE_IMG_PATH);
                }
                pictureBox1 = null;
                pictureBox2 = null;
                NUM_OF_OPEN_TILES = 0;
                if(isCorrect)
                    HandleClicks(sender, e);
            } 
        }
       
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Hello World!");
        }
        private bool IsSame()
        {
            Point point1 = GetPointFromPicBox(pictureBox1);
            Point point2 = GetPointFromPicBox(pictureBox2);
            return point1 == point2;
        }
        private Point GetPointFromPicBox(PictureBox pictureBox)
        {
            int tileNum = pictureBoxes.IndexOf(pictureBox);
            foreach (Point point in answers.Keys)
            {
                if (point.X == tileNum || point.Y == tileNum)
                {
                    return point;
                }
            }
            return new Point();
        }
        private void ShowImg(Object sender, EventArgs e)
        {
            PictureBox imgClicked = (PictureBox)sender;
            Point value = GetPointFromPicBox((PictureBox)imgClicked);
            FileInfo img = (FileInfo)answers[value];

            imgClicked.Image = new Bitmap(img.FullName);
        }
        private void AssignImagesToTiles()
        {
            HashSet<int> indexes = new HashSet<int>();
            DirectoryInfo di = new DirectoryInfo("..\\..\\assets");
            FileInfo[] files = di.GetFiles("*.jpg");

            int fileCounter = 0;

            foreach (FileInfo file in files)
            {
                int setTwice = 0;
                Point pairOfTiles = new Point();

                while (setTwice<2)
                {
                    Random random = new Random();

                    int index = random.Next(0, NUM_OF_TILES);

                    while (!indexes.Add(index))
                        index = random.Next(0, NUM_OF_TILES);

                    if (setTwice == 0)
                        pairOfTiles.X = index;
                    else
                        pairOfTiles.Y = index;
                    setTwice++;
                }
                answers.Add(pairOfTiles, file);
                fileCounter++;
            }
        }
        private void CreateTiles()
        {
            int x = START_POS_X;
            int y = START_POS_Y;
            int height = 130;
            int width = 110;
            int numOfCol = 3;
          

            for (int i = 1; i <= NUM_OF_TILES; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Image= new Bitmap(DEFAULT_TILE_IMG_PATH);
                pb.Location = new Point(x, y);
                pb.Size = new Size(width,height);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Margin = new Padding(3,3,3,3);
                pb.Click += HandleClicks;

                this.Controls.Add(pb);
                pictureBoxes.Add(pb);

                x += HORIZONTAL_SPACE;

                if (i % numOfCol == 0)
                {
                    x = START_POS_X;
                    y += VERTICAL_SPACE;
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
