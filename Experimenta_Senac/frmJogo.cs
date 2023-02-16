using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Experimenta_Senac
{
    public partial class frmJogo : Form
    {
        public frmJogo(bool isHost,string ip = null)
        {
            InitializeComponent();
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            if (isHost)
            {
                CaractereJogador = 'X';
                CaractereOponente = 'O';
                server = new TcpListener(System.Net.IPAddress.Any, 5732);
                server.Start();
                sock = server.AcceptSocket();
            }
            else
            {
                CaractereJogador = 'O';
                CaractereOponente = 'X';
                try
                {
                    client = new TcpClient(ip, 5732);
                    sock = client.Client;
                    MessageReceiver.RunWorkerAsync();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }

 

        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if (VerificarStatus())
                return;
            CongelarJogo();
            lblStatus.Text = "Jogada do Oponente";
            RecebeMovimento();
            lblStatus.Text = "Sua vez!";
            if (!VerificarStatus())
                DescongelarJogo();
        }

        private char CaractereJogador;
        private char CaractereOponente;
        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;

        private bool VerificarStatus()
        {
            //Horizontais - Topo
            if (btnTopLeft.Text == btnTopMiddle.Text && btnTopMiddle.Text == btnTopRight.Text && btnTopRight.Text != "") //TE - TC - TD
            {
                if (btnTopLeft.Text[0] == CaractereJogador)
                {
                    lblStatus.Text = "Você ganhou!";
                    MessageBox.Show("Você ganhou!");
                }
                else 
                {
                    lblStatus.Text = "Você perdeu!";
                    MessageBox.Show("Você perdeu!");
                }
                return true;
            }
            //Horizontais - Meio
           else if (btnMiddleLeft.Text == btnCenter.Text && btnCenter.Text == btnMiddleRight.Text && btnMiddleRight.Text != "") //ME - C - MD 
            {
                if (btnMiddleLeft.Text[0] == CaractereJogador)
                {
                    lblStatus.Text = "Você ganhou!";
                    MessageBox.Show("Você ganhou!");
                }
                else
                {
                    lblStatus.Text = "Você perdeu!";
                    MessageBox.Show("Você perdeu!");
                }
                return true;
            }
            //Horizontais - Baixo
            else if (btnButtonLeft.Text == btnButtonMiddle.Text && btnButtonMiddle.Text == btnButtonRight.Text && btnButtonRight.Text != "") //BE - BC - BD
            {
                if (btnButtonLeft.Text[0] == CaractereJogador)
                {
                    lblStatus.Text = "Você ganhou!";
                    MessageBox.Show("Você ganhou!");
                }
                else
                {
                    lblStatus.Text = "Você perdeu!";
                    MessageBox.Show("Você perdeu!");
                }
                return true;
            }

            //Vertical - Esquerda
            else if (btnTopLeft.Text == btnMiddleLeft.Text && btnMiddleLeft.Text == btnButtonLeft.Text && btnButtonLeft.Text != "") //TE - ME - BE
            {
                if (btnTopLeft.Text[0] == CaractereJogador)
                {
                    lblStatus.Text = "Você ganhou!";
                    MessageBox.Show("Você ganhou!");
                }
                else
                {
                    lblStatus.Text = "Você perdeu!";
                    MessageBox.Show("Você perdeu!");
                }
                return true;
            }
            //Vertical - Centro
            else if (btnTopMiddle.Text == btnCenter.Text && btnCenter.Text == btnButtonMiddle.Text && btnButtonMiddle.Text != "") //TC - C - BC
            {
                if (btnTopMiddle.Text[0] == CaractereJogador)
                {
                    lblStatus.Text = "Você ganhou!";
                    MessageBox.Show("Você ganhou!");
                }
                else
                {
                    lblStatus.Text = "Você perdeu!";
                    MessageBox.Show("Você perdeu!");
                }
                return true;
            }

            //Vertical - Direta
            else if (btnTopRight.Text == btnMiddleRight.Text && btnMiddleRight.Text == btnButtonRight.Text && btnButtonRight.Text != "") //TD - MD - BD
            {
                if (btnTopRight.Text[0] == CaractereJogador)
                {
                    lblStatus.Text = "Você ganhou!";
                    MessageBox.Show("Você ganhou!");
                }
                else
                {
                    lblStatus.Text = "Você perdeu!";
                    MessageBox.Show("Você perdeu!");
                }
                return true;
            }

            //Diagonais TE - C - BD
            else if (btnTopLeft.Text == btnCenter.Text && btnCenter.Text == btnButtonRight.Text && btnButtonRight.Text != "")
            {
                if (btnTopLeft.Text[0] == CaractereJogador)
                {
                    lblStatus.Text = "Você ganhou!";
                    MessageBox.Show("Você ganhou!");
                }
                else
                {
                    lblStatus.Text = "Você perdeu!";
                    MessageBox.Show("Você perdeu!");
                }
                return true;
            }

            //Diagonais BE - C - TD
            else if (btnButtonLeft.Text == btnCenter.Text && btnCenter.Text == btnTopRight.Text && btnTopRight.Text != "")
            {
                if (btnButtonLeft.Text[0] == CaractereJogador)
                {
                    lblStatus.Text = "Você ganhou!";
                    MessageBox.Show("Você ganhou!");
                }
                else
                {
                    lblStatus.Text = "Você perdeu!";
                    MessageBox.Show("Você perdeu!");
                }
                return true;
            }

            //EMPATE
            else if (btnTopLeft.Text != "" && btnTopMiddle.Text != "" && btnTopRight.Text != "" &&btnMiddleLeft.Text != "" && btnCenter.Text != "" && btnMiddleRight.Text != "" && btnButtonLeft.Text != "" && btnButtonMiddle.Text != "" && btnButtonRight.Text != "")
            {
               
            }
            return false;
        }
        private void CongelarJogo()
        {
            btnTopLeft.Enabled = false; //1
            btnTopMiddle.Enabled = false; //2
            btnTopRight.Enabled = false; //3
            btnMiddleLeft.Enabled = false; //4
            btnCenter.Enabled = false; //5 
            btnMiddleRight.Enabled = false; //6
            btnButtonLeft.Enabled = false; //7
            btnButtonMiddle.Enabled = false; //8
            btnButtonRight.Enabled = false; //9
            
        }
        private void DescongelarJogo()
        {
            if(btnTopLeft.Text == "")
                btnTopLeft.Enabled = true; //1
            if (btnTopMiddle.Text == "")
                btnTopMiddle.Enabled = true; //2
            if (btnTopRight.Text == "")
                btnTopRight.Enabled = true; //3
            if (btnMiddleLeft.Text == "")
                btnMiddleLeft.Enabled = true; //4
            if (btnCenter.Text == "")
                btnCenter.Enabled = true; //5
            if (btnMiddleRight.Text == "")
                btnMiddleRight.Enabled = true; //6
            if (btnButtonLeft.Text == "")
                btnButtonLeft.Enabled = true; //7
            if (btnButtonMiddle.Text == "")
                btnButtonMiddle.Enabled = true; //8
            if (btnButtonRight.Text == "")
                btnButtonRight.Enabled = true; //9
        }
        private void RecebeMovimento()
        {
            byte[] buffer = new byte[1];
            sock.Receive(buffer);
            if (buffer[0] == 1)
            {
                btnTopLeft.Text = CaractereOponente.ToString(); //1
            }
            if (buffer[0] == 2)
            {
                btnTopMiddle.Text = CaractereOponente.ToString(); //2
            }
            if (buffer[0] == 3)
            {
                btnTopRight.Text = CaractereOponente.ToString(); //3
            }
            if (buffer[0] == 4)
            {
                btnMiddleLeft.Text = CaractereOponente.ToString(); //4
            }
            if (buffer[0] == 5)
            {
                btnCenter.Text = CaractereOponente.ToString(); //5
            }
            if (buffer[0] == 6)
            {
                btnMiddleRight.Text = CaractereOponente.ToString(); //6
            }
            if (buffer[0] == 7)
            {
                btnButtonLeft.Text = CaractereOponente.ToString(); //7
            }
            if (buffer[0] == 8)
            {
                btnButtonMiddle.Text = CaractereOponente.ToString(); //8
            }
            if (buffer[0] == 9)
            {
                btnButtonRight.Text = CaractereOponente.ToString(); //9
            }
        }

        private void btnTopLeft_Click(object sender, EventArgs e)
        {
            byte[] num = { 1 };
            sock.Send(num);
            btnTopLeft.Text = CaractereJogador.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void btnTopMiddle_Click(object sender, EventArgs e)
        {
            byte[] num = { 2 };
            sock.Send(num);
            btnTopMiddle.Text = CaractereJogador.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void btnTopRight_Click(object sender, EventArgs e)
        {
            byte[] num = { 3 };
            sock.Send(num);
            btnTopRight.Text = CaractereJogador.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void btnMiddleLeft_Click(object sender, EventArgs e)
        {
            byte[] num = { 4 };
            sock.Send(num);
            btnMiddleLeft.Text = CaractereJogador.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            byte[] num = { 5 };
            sock.Send(num);
            btnCenter.Text = CaractereJogador.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void btnMiddleRight_Click(object sender, EventArgs e)
        {
            byte[] num = { 6 };
            sock.Send(num);
            btnMiddleRight.Text = CaractereJogador.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void btnButtonLeft_Click(object sender, EventArgs e)
        {
            byte[] num = { 7 };
            sock.Send(num);
            btnButtonLeft.Text = CaractereJogador.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void btnButtonMiddle_Click(object sender, EventArgs e)
        {
            byte[] num = { 8 };
            sock.Send(num);
            btnButtonMiddle.Text = CaractereJogador.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void btnButtonRight_Click(object sender, EventArgs e)
        {
            byte[] num = { 9 };
            sock.Send(num);
            btnButtonRight.Text = CaractereJogador.ToString();
            MessageReceiver.RunWorkerAsync();
        }

        private void frmJogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageReceiver.WorkerSupportsCancellation= true;
            MessageReceiver.CancelAsync();
            if(server != null)
            {
                server.Stop();
            }
        }
    }
}
