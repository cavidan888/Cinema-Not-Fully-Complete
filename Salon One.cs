using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace letsCinema
{
    public partial class Salon_One : Form
    {
        public int LeftPos;
        public int b = 20;
        public new int Top = 50;
        public new int Left = 40;

        public Salon_One()
        {
            InitializeComponent();
        }

        private void Salon_One_Load(object sender, EventArgs e)
        {

            CreateOnix();



            //List<Button> buttons = new List<Button>();
            //for (int i = 0; i < 10; i++)
            //{
            //    Button newButton = new Button();
            //    buttons.Add(newButton);
            //    this.Controls.Add(newButton);
            //}

        }

        public void CreateOnix()
        {
             //int onixCount = 25;

            //for (int i = 0; i < onixCount; i++)
            //{
            //    for (int j = 0; j < onixCount; j++)
            //    {
            //        Button onix = new Button();
            //        onix.Width = 60;
            //        onix.Height = 30;
            //        onix.Left = LeftPos;
            //        onix.Text = "click me";
            //        onix.FlatStyle = FlatStyle.Flat;
            //        onix.BackColor = Color.Silver;
            //        onix.ForeColor = Color.White;
                    //onix.Left = (this.ClientSize.Width - onix.Width) / 2;
                    //onix.Top = (this.ClientSize.Height - onix.Height) / 4;
                    //Controls.Add(onix);
                    //LeftPos += 60;

                    //if (Left - 40 == btn.Width * 20)
                    //{
                    //    Top += btn.Height;
                    //    Left = 40;
                    //}

                }
                
            }
        }
//    }
//}
