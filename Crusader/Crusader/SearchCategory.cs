using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crusader
{
    public partial class SearchCategory : Form
    {
        public SearchCategory()
        {
            InitializeComponent();
        }

        private void btnNPC_Click(object sender, EventArgs e)
        {
            new NPCSearch().ShowDialog();
        }

        private void btnChapter_Click(object sender, EventArgs e)
        {
            new ChapterSearch().ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
        }

        private void btnHero_Click(object sender, EventArgs e)
        {
            new HeroSearch().ShowDialog();
        }

        private void btnResource_Click(object sender, EventArgs e)
        {
            new ResourceSearch().ShowDialog();
        }
    }
}
