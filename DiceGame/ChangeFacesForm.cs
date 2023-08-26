using System;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class ChangeFacesForm : Form
    {
        private int[] faces;
        private Button firstButton;
        private Button secondButton;
        private bool changed;
        private int incrementer;
        public int[] Faces
        {
            get
            {
                return faces;
            }

            set
            {
                faces = value;
            }
        }

        public bool Changed
        {
            get
            {
                return changed;
            }

            set
            {
                changed = value;
            }
        }

        public ChangeFacesForm()
        {
            InitializeComponent();
        }

        private void ChangeFacesForm_Load(object sender, EventArgs e)
        {
            btnFace1.FlatAppearance.MouseOverBackColor = btnFace1.BackColor;
            btnFace2.FlatAppearance.MouseOverBackColor = btnFace2.BackColor;
            btnFace3.FlatAppearance.MouseOverBackColor = btnFace3.BackColor;
            btnFace4.FlatAppearance.MouseOverBackColor = btnFace4.BackColor;
            btnFace5.FlatAppearance.MouseOverBackColor = btnFace5.BackColor;
            btnFace6.FlatAppearance.MouseOverBackColor = btnFace6.BackColor;
            setArray();
            btnFace2.MouseDown += new MouseEventHandler(btnFace1_MouseDown);
            btnFace2.DragEnter += new DragEventHandler(btnFace1_DragEnter);
            btnFace2.DragDrop += new DragEventHandler(btnFace1_DragDrop);
            btnFace3.MouseDown += new MouseEventHandler(btnFace1_MouseDown);
            btnFace3.DragEnter += new DragEventHandler(btnFace1_DragEnter);
            btnFace3.DragDrop += new DragEventHandler(btnFace1_DragDrop);
            btnFace4.MouseDown += new MouseEventHandler(btnFace1_MouseDown);
            btnFace4.DragEnter += new DragEventHandler(btnFace1_DragEnter);
            btnFace4.DragDrop += new DragEventHandler(btnFace1_DragDrop);
            btnFace5.MouseDown += new MouseEventHandler(btnFace1_MouseDown);
            btnFace5.DragEnter += new DragEventHandler(btnFace1_DragEnter);
            btnFace5.DragDrop += new DragEventHandler(btnFace1_DragDrop);
            btnFace6.MouseDown += new MouseEventHandler(btnFace1_MouseDown);
            btnFace6.DragEnter += new DragEventHandler(btnFace1_DragEnter);
            btnFace6.DragDrop += new DragEventHandler(btnFace1_DragDrop);
            incrementer = 1;
        }

        private void changeNumber(Button first, Button second)
        {
            int firstValue = Int32.Parse(first.Text);
            int secondValue = Int32.Parse(second.Text);
            if (firstValue == 0)
            {}
            else
            {
                firstValue -= incrementer;
                secondValue += incrementer;
                first.Text = firstValue.ToString();
                second.Text = secondValue.ToString();
                Changed = true;
            }
        }
        private void setArray()
        {
            btnFace1.Text = faces[0].ToString();
            btnFace2.Text = faces[1].ToString();
            btnFace3.Text = faces[2].ToString();
            btnFace4.Text = faces[3].ToString();
            btnFace5.Text = faces[4].ToString();
            btnFace6.Text = faces[5].ToString();

            int facesSum = faces[0] + faces[1] + faces[2] + faces[3] + faces[4] + faces[5];
            if (facesSum <= 40)
            {
                radBtn2.Visible = false;
                radBtn5.Visible = false;
                radBtn10.Visible = false;
            }
            else if (facesSum > 40 && facesSum <= 60)
            {
                radBtn5.Visible = false;
                radBtn10.Visible = false;
            }
            else if (facesSum > 60 && facesSum <= 80)
            {
                radBtn5.Visible = false;
                radBtn10.Visible = false;
            }
            else if (facesSum > 80 && facesSum <= 100)
            {
                radBtn10.Visible = false;
            }

        }

        private void btnFace1_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            firstButton = btn;
            btn.Select();
            btn.DoDragDrop(btn.Text, DragDropEffects.All);
        }

        private void btnFace1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btnFace1_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = (Button)sender;
            secondButton = btn;
            if (Changed == false && firstButton!=secondButton)
            {
                changeNumber(firstButton, secondButton);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setArray();
            Changed = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            faces[0] = Int32.Parse(btnFace1.Text);
            faces[1] = Int32.Parse(btnFace2.Text);
            faces[2] = Int32.Parse(btnFace3.Text);
            faces[3] = Int32.Parse(btnFace4.Text);
            faces[4] = Int32.Parse(btnFace5.Text);
            faces[5] = Int32.Parse(btnFace6.Text);
            Changed = true;
            this.Close();
        }

        public int[] returnFaces()
        {
            return faces;
        }

        private void faceChanged()
        {
            if (radBtn1.Checked == true)
            {
                incrementer = 1;
            }
            else if (radBtn2.Checked == true)
            {
                incrementer = 2;
            }
            else if (radBtn5.Checked == true)
            {
                incrementer = 5;
            }
            else
            {
                incrementer = 10;
            }
        }

        private void radBtn1_CheckedChanged(object sender, EventArgs e)
        {
            faceChanged();
        }

        private void radBtn2_CheckedChanged(object sender, EventArgs e)
        {
            faceChanged();
        }

        private void radBtn5_CheckedChanged(object sender, EventArgs e)
        {
            faceChanged();
        }

        private void radBtn10_CheckedChanged(object sender, EventArgs e)
        {
            faceChanged();
        }
    }
}
