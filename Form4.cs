using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirds
{
    public partial class ScoreBoard : Form
    {
        public ScoreBoard()
        {
            InitializeComponent();
        }

        public void SetScores()
        {
            var items = ScoreUtils.ReadTopScores()
                .Select(item => new ListViewItem(item.ToString()))
                .ToArray();
            
            listView1.Items.AddRange(items);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
