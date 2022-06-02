namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTL_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            winchecker();
        }
        private void winchecker()
        {
            bool winner = false;
            if ((btnTL.Text == btnTC.Text && btnTC.Text == btnTR.Text && !btnTL.Enabled))
                winner = true;
            else if ((btnCL.Text == btnCC.Text && btnCC.Text == btnCR.Text && !btnCL.Enabled))
                winner = true;
            else if ((btnLL.Text == btnLC.Text && btnLC.Text == btnLR.Text && !btnLL.Enabled))
                winner = true;

            if ((btnTL.Text == btnCL.Text && btnCL.Text == btnLL.Text && !btnTL.Enabled))
                winner = true;
            else if ((btnTC.Text == btnCC.Text && btnCC.Text == btnLC.Text && !btnTC.Enabled))
                winner = true;
            else if ((btnTR.Text == btnCR.Text && btnCR.Text == btnLR.Text && !btnTR.Enabled))
                winner = true;

            if ((btnTL.Text == btnCC.Text && btnCC.Text == btnLR.Text && !btnTL.Enabled))
                winner = true;
            else if ((btnTR.Text == btnCC.Text && btnCC.Text == btnLL.Text && !btnTR.Enabled))
                winner = true;

            if (winner)
            {
                string win = "";
                if (turn)
                {
                    win = "O";
                    lblP2.Text = (int.Parse(lblP2.Text) + 1).ToString();


                }
                else
                {
                    win = "X";
                    lblP1.Text = (int.Parse(lblP1.Text) +1).ToString();
                }
                btnTL.Enabled = false;
                btnTC.Enabled = false;
                btnTR.Enabled = false;
                btnCL.Enabled = false;
                btnCC.Enabled = false;
                btnCR.Enabled = false;
                btnLL.Enabled = false;
                btnLC.Enabled = false;
                btnLR.Enabled = false;
                MessageBox.Show(win + " Wins!" + " Yay!");
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!");
                    lblDraw.Text = (int.Parse(lblDraw.Text) + 1).ToString();
                }
            }
            
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;


            btnTL.Enabled = true;
            btnTC.Enabled = true;
            btnTR.Enabled = true;
            btnCL.Enabled = true;
            btnCC.Enabled = true;
            btnCR.Enabled = true;
            btnLL.Enabled = true;
            btnLC.Enabled = true;
            btnLR.Enabled = true;

                btnTL.Text = "";
                btnTC.Text = "";
                btnTR.Text = "";
                btnCL.Text = "";
                btnCC.Text = "";
                btnCR.Text = "";
                btnLL.Text = "";
                btnLC.Text = "";
                btnLR.Text = "";

            lblP1.Text = "0";
            lblP2.Text = "0";
            lblDraw.Text = "0";
           


        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            btnTL.Enabled = true;
            btnTC.Enabled = true;
            btnTR.Enabled = true;
            btnCL.Enabled = true;
            btnCC.Enabled = true;
            btnCR.Enabled = true;
            btnLL.Enabled = true;
            btnLC.Enabled = true;
            btnLR.Enabled = true;

            btnTL.Text = "";
            btnTC.Text = "";
            btnTR.Text = "";
            btnCL.Text = "";
            btnCC.Text = "";
            btnCR.Text = "";
            btnLL.Text = "";
            btnLC.Text = "";
            btnLR.Text = "";

            
        }
    }
}