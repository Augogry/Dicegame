using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class UseSpecialForm : Form
    {
        string name;
        string prompt;
        int increment;
        int choices;
        int[] faceValues = new int[6];
        int[] modifiedValues = new int[6];
        string prev;

        public UseSpecialForm()
        {
            InitializeComponent();
        }

        private void UseSpecialForm_Load(object sender, EventArgs e)
        {
            lblItemName.Text = name;
            lblMessage.Text = prompt;
            modifiedValues = new int[6] { faceValues[0], faceValues[1], faceValues[2], faceValues[3], faceValues[4], faceValues[5] };
            updateForm();
            if (!(name.Equals("Staff")))
            {
                grpbxChangeBy.Visible = false;
            }
        }

        public void ShowDialog(string itemName, string itemPrompt, int[] faces, int increment, int choices)
        {
            this.name = itemName;
            this.prompt = itemPrompt;
            this.faceValues = faces;
            this.increment = increment;
            this.choices = choices;
            ShowDialog();
        }

        private void updateForm()
        {
            face1.Text = modifiedValues[0].ToString();
            face2.Text = modifiedValues[1].ToString();
            face3.Text = modifiedValues[2].ToString();
            face4.Text = modifiedValues[3].ToString();
            face5.Text = modifiedValues[4].ToString();
            face6.Text = modifiedValues[5].ToString();
        }

        private void chkbxFace1_Clicked(object sender, EventArgs e)
        {
            checkBoxAction(chkbxFace1, face1);
        }

        private void chkbxFace2_Clicked(object sender, EventArgs e)
        {
            checkBoxAction(chkbxFace2, face2);
        }

        private void chkbxFace3_Clicked(object sender, EventArgs e)
        {
            checkBoxAction(chkbxFace3, face3);
        }

        private void chkbxFace4_Clicked(object sender, EventArgs e)
        {
            checkBoxAction(chkbxFace4, face4);
        }

        private void chkbxFace5_Clicked(object sender, EventArgs e)
        {
            checkBoxAction(chkbxFace5, face5);
        }

        private void chkbxFace6_Clicked(object sender, EventArgs e)
        {
            checkBoxAction(chkbxFace6, face6);
        }

        private int countChecked()
        {
            int chosen = 0;
            if (chkbxFace1.Checked == true)
            {
                chosen++;
            }
            if (chkbxFace2.Checked == true)
            {
                chosen++;
            }
            if (chkbxFace3.Checked == true)
            {
                chosen++;
            }
            if (chkbxFace4.Checked == true)
            {
                chosen++;
            }
            if (chkbxFace5.Checked == true)
            {
                chosen++;
            }
            if (chkbxFace6.Checked == true)
            {
                chosen++;
            }
            return chosen;
        }

        private void enableButton()
        {
            if (countChecked() < choices)
            {
                btnDone.Enabled = false;
            }
            else
            {
                btnDone.Enabled = true;
            }
        }

        public string[] getChanges()
        {
            return new string[6] { face1.Text, face2.Text, face3.Text, face4.Text, face5.Text, face6.Text};
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (btnDone.Enabled == true)
            {
                this.Close();
            }
        }

        private void checkBoxAction(CheckBox chkbx, Button face)
        {
            if (chkbx.Checked == false)
            {
                if (countChecked() >= choices)
                {
                    chkbx.Checked = false;
                }
                else
                {
                    if (face.Text.Equals("❂"))
                    {
                        face.Text = prev;
                    }
                    else
                    {
                        face.Text = (Int32.Parse(face.Text) - increment).ToString();
                    }  
                }
            }
            else
            {
                if (name.Equals("Staff"))
                {
                    if (rdbtn2.Checked == true)
                    {
                        prev = face.Text;
                        face.Text = "❂";
                    }
                    else if (rdbtn2.Checked == false)
                    {
                        face.Text = (Int32.Parse(face.Text) + increment).ToString();
                    }
                }
                else
                {
                    face.Text = (Int32.Parse(face.Text) + increment).ToString();
                }
            }
            enableButton();
        }
    }
}
