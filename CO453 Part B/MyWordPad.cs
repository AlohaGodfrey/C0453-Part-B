using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453_Part_B
{/// <summary>
 /// Task 3.7 - 3.10
 /// This form uses a rich text box to provide the main functions
 /// of a simple word pad.
 /// Author: Godfrey
 /// </summary>
    public partial class MyWordPad : Form
    {
        

        public MyWordPad()
        {
            InitializeComponent();
        }

        private void setBackColour(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            mainRichTextBox.BackColor = colorDialog1.Color;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainRichTextBox.Cut();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainRichTextBox.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainRichTextBox.Copy();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainRichTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainRichTextBox.Redo();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            mainRichTextBox.SaveFile(saveFileDialog1.FileName);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            mainRichTextBox.LoadFile(openFileDialog1.FileName);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            mainRichTextBox.Font = fontDialog1.Font;
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            mainRichTextBox.ForeColor = colorDialog1.Color;
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            Font f = new Font(mainRichTextBox.Font.Name, hScrollBar1.Value, FontStyle.Regular);
            mainRichTextBox.SelectionFont = f;
        }
    }
}
