using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Printer2D_Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            COM = new System.IO.Ports.SerialPort(cboxCOM.Text, 9600);

            linea = new Pen(Color.DeepSkyBlue, 1/2);
            BMSAVE = new Bitmap(panelLONA.ClientRectangle.Width, panelLONA.ClientRectangle.Height);
            LONA = new Bitmap(panelLONA.ClientRectangle.Width, panelLONA.ClientRectangle.Height);
            G = Graphics.FromImage(LONA);
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        /////////////////
        //////////////////////////////////

        SerialPort COM;

        Bitmap LONA, BMSAVE; Graphics G;
        Pen linea; bool Ocp = false;
        int X = 0, Y = 0;
        string eFORMA;
        int[] P;

        //////////////////////////////////
        /////////////////

        public bool PuertoSerial(string cmd)
        {
            if (COM.IsOpen)
            {
                COM.Write(cmd);
                return true;
            }
            else
            {
                return false;
            }

        }

        public void DIBUJAR(string FORMA, int[] E)
        {           
            if (FORMA == "linea" && E.Length == 4)
            {
                G.DrawLine(linea, new Point(E[0], E[1]), new Point(E[2], E[3]));
                panelLONA.Refresh();               
            }
            else if (FORMA == "Rectangulo")
            {
                G.DrawRectangle(linea, new Rectangle(50,50, 300, 250));
                panelLONA.Refresh();
            }
            else if (FORMA == "Elipse")
            {
                G.DrawEllipse(linea, 50, 50, 100, 100);
                panelLONA.Refresh();
            }
            else if (FORMA == "Arco")
            {
                G.DrawArc(linea, new Rectangle(50, 50, 100, 100), 0, 120); 
                panelLONA.Refresh();
            }

            if (Ocp == false)
            {
                BMSAVE = LONA;
            }
        }

        private void panelLONA_MouseMove(object sender, MouseEventArgs e)
        {
            X = (Cursor.Position.X - Form1.ActiveForm.Location.X) - (Form1.ActiveForm.Width - Form1.ActiveForm.ClientRectangle.Width) - panelLONA.Location.X + 8;
            Y = (Cursor.Position.Y - Form1.ActiveForm.Location.Y) - (Form1.ActiveForm.Height - Form1.ActiveForm.ClientRectangle.Height) - panelLONA.Location.Y + 8;

            lb_Info_Pxy.Text = "Eje[cm] X=  " + X + " :: Y=  " + Y;
        }

        ////
        //////// REPRESENTACION DE GRAFICOS EN LONA
        //////////////////////////////////////////////////////////////////////////////////////////
        private void panelLONA_Paint(object sender, PaintEventArgs e)
        {
            if (LONA != null)
            {               
                e.Graphics.DrawImage(LONA, 0, 0);
                //LONA.Dispose();
                //G.Dispose();
                //e.Dispose();
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////
        /////////

        private void btn_Draw_Line_Click(object sender, EventArgs e)
        {
            eFORMA = "linea";
            P = new int[4];
            DIBUJAR(eFORMA, P);
        }

        private void btn_Draw_Elip_Click(object sender, EventArgs e)
        {
            eFORMA = "Elipse";
            DIBUJAR(eFORMA, P);
        }

        private void btn_Draw_Rect_Click(object sender, EventArgs e)
        {
            eFORMA = "Rectangulo";
            DIBUJAR(eFORMA, P);
        }

        private void btn_Draw_Arc_Click(object sender, EventArgs e)
        {
            eFORMA = "Arco";
            DIBUJAR(eFORMA, P);
        }

        private void btn_Draw_Lineas_Click(object sender, EventArgs e)
        {
            eFORMA = "linea";
            P = new int[4];
            for (int i = 0; i < 4; i++)
            {
                P[i] = i * 25;
            }            
            DIBUJAR(eFORMA, P);
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////
        /////////
    }
}
