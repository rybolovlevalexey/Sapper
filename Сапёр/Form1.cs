using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сапёр
{
    public partial class Form1 : Form
    {
        Dictionary<int, int> field_bombs_numbers;
        int[] bombs_indexes = new int[15];
        public Form1()
        {
            InitializeComponent();
        }

        private void start_game_pushed(object sender, EventArgs e)
        {
            Random rnd = new Random();
            while (bombs_indexes.Length < 15)
            {
                int ind = rnd.Next(1, 100);
                bool flag = true;
                foreach (var elem in bombs_indexes)
                {

                }
            }
        }
    }
}
