namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLR = new System.Windows.Forms.Button();
            this.btnLC = new System.Windows.Forms.Button();
            this.btnLL = new System.Windows.Forms.Button();
            this.btnCR = new System.Windows.Forms.Button();
            this.btnCC = new System.Windows.Forms.Button();
            this.btnCL = new System.Windows.Forms.Button();
            this.btnTR = new System.Windows.Forms.Button();
            this.btnTC = new System.Windows.Forms.Button();
            this.btnTL = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(388, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(23, 24);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "X";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(199, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Draw";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(323, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Player 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 13;
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(94, 409);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(13, 15);
            this.lblP1.TabIndex = 14;
            this.lblP1.Text = "0";
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Location = new System.Drawing.Point(210, 409);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(13, 15);
            this.lblDraw.TabIndex = 15;
            this.lblDraw.Text = "0";
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Location = new System.Drawing.Point(338, 409);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(13, 15);
            this.lblP2.TabIndex = 16;
            this.lblP2.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnLR);
            this.panel1.Controls.Add(this.btnLC);
            this.panel1.Controls.Add(this.btnLL);
            this.panel1.Controls.Add(this.btnCR);
            this.panel1.Controls.Add(this.btnCC);
            this.panel1.Controls.Add(this.btnCL);
            this.panel1.Controls.Add(this.btnTR);
            this.panel1.Controls.Add(this.btnTC);
            this.panel1.Controls.Add(this.btnTL);
            this.panel1.Location = new System.Drawing.Point(49, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 315);
            this.panel1.TabIndex = 17;
            // 
            // btnLR
            // 
            this.btnLR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLR.Location = new System.Drawing.Point(225, 212);
            this.btnLR.Name = "btnLR";
            this.btnLR.Size = new System.Drawing.Size(98, 94);
            this.btnLR.TabIndex = 8;
            this.btnLR.Text = " ";
            this.btnLR.UseVisualStyleBackColor = true;
            this.btnLR.Click += new System.EventHandler(this.button_click);
            // 
            // btnLC
            // 
            this.btnLC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLC.Location = new System.Drawing.Point(121, 212);
            this.btnLC.Name = "btnLC";
            this.btnLC.Size = new System.Drawing.Size(98, 94);
            this.btnLC.TabIndex = 7;
            this.btnLC.Text = " ";
            this.btnLC.UseVisualStyleBackColor = true;
            this.btnLC.Click += new System.EventHandler(this.button_click);
            // 
            // btnLL
            // 
            this.btnLL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLL.Location = new System.Drawing.Point(17, 212);
            this.btnLL.Name = "btnLL";
            this.btnLL.Size = new System.Drawing.Size(98, 94);
            this.btnLL.TabIndex = 6;
            this.btnLL.Text = " ";
            this.btnLL.UseVisualStyleBackColor = true;
            this.btnLL.Click += new System.EventHandler(this.button_click);
            // 
            // btnCR
            // 
            this.btnCR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCR.Location = new System.Drawing.Point(225, 115);
            this.btnCR.Name = "btnCR";
            this.btnCR.Size = new System.Drawing.Size(98, 94);
            this.btnCR.TabIndex = 5;
            this.btnCR.Text = " ";
            this.btnCR.UseVisualStyleBackColor = true;
            this.btnCR.Click += new System.EventHandler(this.button_click);
            // 
            // btnCC
            // 
            this.btnCC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCC.Location = new System.Drawing.Point(121, 115);
            this.btnCC.Name = "btnCC";
            this.btnCC.Size = new System.Drawing.Size(98, 94);
            this.btnCC.TabIndex = 4;
            this.btnCC.Text = " ";
            this.btnCC.UseVisualStyleBackColor = true;
            this.btnCC.Click += new System.EventHandler(this.button_click);
            // 
            // btnCL
            // 
            this.btnCL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCL.Location = new System.Drawing.Point(17, 115);
            this.btnCL.Name = "btnCL";
            this.btnCL.Size = new System.Drawing.Size(98, 94);
            this.btnCL.TabIndex = 3;
            this.btnCL.Text = " ";
            this.btnCL.UseVisualStyleBackColor = true;
            this.btnCL.Click += new System.EventHandler(this.button_click);
            // 
            // btnTR
            // 
            this.btnTR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTR.Location = new System.Drawing.Point(225, 15);
            this.btnTR.Name = "btnTR";
            this.btnTR.Size = new System.Drawing.Size(98, 94);
            this.btnTR.TabIndex = 2;
            this.btnTR.Text = " ";
            this.btnTR.UseVisualStyleBackColor = true;
            this.btnTR.Click += new System.EventHandler(this.button_click);
            // 
            // btnTC
            // 
            this.btnTC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTC.Location = new System.Drawing.Point(121, 15);
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(98, 94);
            this.btnTC.TabIndex = 1;
            this.btnTC.Text = " ";
            this.btnTC.UseVisualStyleBackColor = true;
            this.btnTC.Click += new System.EventHandler(this.button_click);
            // 
            // btnTL
            // 
            this.btnTL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTL.Location = new System.Drawing.Point(17, 15);
            this.btnTL.Name = "btnTL";
            this.btnTL.Size = new System.Drawing.Size(98, 94);
            this.btnTL.TabIndex = 0;
            this.btnTL.Text = " ";
            this.btnTL.UseVisualStyleBackColor = true;
            this.btnTL.Click += new System.EventHandler(this.button_click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(49, 38);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewGame.Location = new System.Drawing.Point(159, 38);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(95, 23);
            this.btnNewGame.TabIndex = 18;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 451);
            this.ControlBox = false;
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblP1;
        private Label lblDraw;
        private Label lblP2;
        private Panel panel1;
        private Button btnLR;
        private Button btnLC;
        private Button btnLL;
        private Button btnCR;
        private Button btnCC;
        private Button btnCL;
        private Button btnTR;
        private Button btnTC;
        private Button btnTL;
        private Button btnReset;
        private Button btnNewGame;
    }
}