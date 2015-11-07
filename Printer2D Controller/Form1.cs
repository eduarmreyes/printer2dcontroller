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
        int X = 0, Y = 0, iClick = 0;
        string eFORMA;
        int[] P;

        //////////////////////////////////
        /////////////////

        public bool PuertoSerial(string cmd)
        {
            panelLONA.ToString();
            COM = new System.IO.Ports.SerialPort(cboxCOM.Text, 9600);
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
            switch (FORMA)
            {
                case "linea":
                    G.DrawLine(linea, new Point(E[0], E[1]), new Point(E[2], E[3]));
                    panelLONA.Refresh();
                    break;
                case "Rectangulo":
                    G.DrawRectangle(linea, new Rectangle(E[0],E[1], E[2], E[3]));
                    panelLONA.Refresh();
                    break;
                case "Elipse":
                    G.DrawEllipse(linea, E[0], E[1], E[2], E[3]);
                    panelLONA.Refresh();
                    break;
                default:
                    MessageBox.Show("Debes seleccionar una opción de dibujo","Error",
                        MessageBoxButtons.OK,MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,MessageBoxOptions.ServiceNotification);
                    break;

            }
            //if (FORMA == "Arco")
            //{
            //    // E[4] = startAngle
            //    // E[5] = sweepAngle
            //    // G.DrawArc(linea, new Rectangle(E[0], E[1], E[2], E[3]), 0, 120);
            //    // G.DrawArc(linea, 0, 0, 100, 100, 0, 120);
            //    G.DrawArc(linea, new Rectangle(0, 0, 100, 100), 0, 0);
            //    // G.DrawArc(linea, new Rectangle(E[0], E[1], E[2], E[3]), E[4], E[5]);
            //    panelLONA.Refresh();
            //}

            if (Ocp == false)
            {
                BMSAVE = LONA;
            }
        }

        private void panelLONA_MouseMove(object sender, MouseEventArgs e)
        {
            System.Drawing.Point pPanelPoint = panelLONA.PointToScreen(Point.Empty);
            X = Cursor.Position.X - pPanelPoint.X;
            Y = Cursor.Position.Y - pPanelPoint.Y;
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
        }

        private void btn_Draw_Rect_Click(object sender, EventArgs e)
        {
            eFORMA = "Rectangulo";
        }

        private void btn_Draw_Arc_Click(object sender, EventArgs e)
        {
            eFORMA = "Arco";
        }

        private void btn_Draw_Lineas_Click(object sender, EventArgs e)
        {
            eFORMA = "linea";
        }

        private void panelLONA_MouseClick(object sender, MouseEventArgs e)
        {
            System.Drawing.Point pPoint = panelLONA.PointToScreen(Point.Empty);
            if (iClick == 0) {
                if ((new object[] {eFORMA}).Any(v => v == null))
                {
                    MessageBox.Show("Debes seleccionar una opción de dibujo","Error",
                        MessageBoxButtons.OK,MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,MessageBoxOptions.ServiceNotification);
                }
                else
                {
                    P = new int[6];
                    P[0] = Cursor.Position.X - pPoint.X;
                    P[1] = Cursor.Position.Y - pPoint.Y;
                    iClick++;
                }
            } else {
                P[2] = Cursor.Position.X - pPoint.X;
                P[3] = Cursor.Position.Y - pPoint.Y;
                switch (eFORMA)
                {
                    case "linea":
                        break;
                    case "Rectangulo":
                    case "Elipse" :
                        P[2] = P[2] - P[0];
                        P[3] = P[3] - P[1];
                        break;
                    case "Arco":
                        double radian = 0;
                        double a, b;
                        a = P[1] - P[0];
                        b = P[3] - P[2];
                        radian = (a) / (b);
                        double degrees = 0;
                        degrees = radian * 180 / Math.PI;
                        P[4] = 0;
                        // P[5] = (int) degrees;
                        P[5] = 120;
                        break;
                    default:
                        MessageBox.Show("Por favor elija una opción de dibujo.");
                        break;
                }
                iClick = 0;
                DIBUJAR(eFORMA, P);
            }
        }

        private void btnIMPRIMIR_Click(object sender, EventArgs e)
        {
            string sDraw = panelLONA.ToString();
            if (PuertoSerial(sDraw))
            {
                MessageBox.Show("Impreso");
            }
            else
            {
                MessageBox.Show("No se imprimio. COM usado: " + cboxCOM.Text);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////
        /////////
    }
}
