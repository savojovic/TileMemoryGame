using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Slagalica
{
    internal class Tile
    {
        PictureBox pictureBox;
        bool isOpen;
        string pathToImg;

        public Tile(PictureBox pictureBox, bool isOpen, string pathToImg)
        {
            this.pictureBox = pictureBox;
            this.isOpen = isOpen; 
            this.pathToImg = pathToImg;
        }

        public bool IsOpen() { return isOpen; }
        public void setIsOpen(bool isOpen) { this.isOpen = isOpen; }
        public string getPath() { return pathToImg; }
        public PictureBox PictureBox { get { return pictureBox;} }
    }
}
