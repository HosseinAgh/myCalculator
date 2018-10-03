namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btnpow = new System.Windows.Forms.Button();
            this.btnabs = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btncos = new System.Windows.Forms.Button();
            this.btndivid = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnsin = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBackSpace);
            this.panel1.Controls.Add(this.button21);
            this.panel1.Controls.Add(this.btnsin);
            this.panel1.Controls.Add(this.btnmulti);
            this.panel1.Controls.Add(this.btnsub);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btncos);
            this.panel1.Controls.Add(this.btndivid);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btnabs);
            this.panel1.Controls.Add(this.btnpoint);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btnpow);
            this.panel1.Controls.Add(this.btnequal);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 240);
            this.panel1.TabIndex = 0;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(3, 191);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(51, 41);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.numbers);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(60, 191);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(51, 41);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.numbers);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(117, 191);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(51, 41);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.numbers);
            // 
            // btnequal
            // 
            this.btnequal.Location = new System.Drawing.Point(174, 191);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(51, 41);
            this.btnequal.TabIndex = 3;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btnpow
            // 
            this.btnpow.Location = new System.Drawing.Point(231, 191);
            this.btnpow.Name = "btnpow";
            this.btnpow.Size = new System.Drawing.Size(51, 41);
            this.btnpow.TabIndex = 4;
            this.btnpow.Text = "pow";
            this.btnpow.UseVisualStyleBackColor = true;
            this.btnpow.Click += new System.EventHandler(this.operators);
            // 
            // btnabs
            // 
            this.btnabs.Location = new System.Drawing.Point(231, 144);
            this.btnabs.Name = "btnabs";
            this.btnabs.Size = new System.Drawing.Size(51, 41);
            this.btnabs.TabIndex = 9;
            this.btnabs.Text = "Abs";
            this.btnabs.UseVisualStyleBackColor = true;
            this.btnabs.Click += new System.EventHandler(this.btnadvance_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.Location = new System.Drawing.Point(174, 144);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(51, 41);
            this.btnpoint.TabIndex = 8;
            this.btnpoint.Text = ".";
            this.btnpoint.UseVisualStyleBackColor = true;
            this.btnpoint.Click += new System.EventHandler(this.numbers);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(117, 144);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(51, 41);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.numbers);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(60, 144);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(51, 41);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.numbers);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(3, 144);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(51, 41);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.numbers);
            // 
            // btncos
            // 
            this.btncos.Location = new System.Drawing.Point(231, 97);
            this.btncos.Name = "btncos";
            this.btncos.Size = new System.Drawing.Size(51, 41);
            this.btncos.TabIndex = 14;
            this.btncos.Text = "Cos";
            this.btncos.UseVisualStyleBackColor = true;
            this.btncos.Click += new System.EventHandler(this.btnadvance_Click);
            // 
            // btndivid
            // 
            this.btndivid.Location = new System.Drawing.Point(174, 97);
            this.btndivid.Name = "btndivid";
            this.btndivid.Size = new System.Drawing.Size(51, 41);
            this.btndivid.TabIndex = 13;
            this.btndivid.Text = "/";
            this.btndivid.UseVisualStyleBackColor = true;
            this.btndivid.Click += new System.EventHandler(this.operators);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(117, 97);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(51, 41);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.numbers);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(60, 97);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(51, 41);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.numbers);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(3, 97);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(51, 41);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.numbers);
            // 
            // btnsin
            // 
            this.btnsin.Location = new System.Drawing.Point(231, 50);
            this.btnsin.Name = "btnsin";
            this.btnsin.Size = new System.Drawing.Size(51, 41);
            this.btnsin.TabIndex = 19;
            this.btnsin.Text = "Sin";
            this.btnsin.UseVisualStyleBackColor = true;
            this.btnsin.Click += new System.EventHandler(this.btnadvance_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Location = new System.Drawing.Point(174, 50);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(51, 41);
            this.btnmulti.TabIndex = 18;
            this.btnmulti.Text = "*";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.operators);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(117, 50);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(51, 41);
            this.btnsub.TabIndex = 17;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.operators);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(60, 50);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(51, 41);
            this.btnadd.TabIndex = 16;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.operators);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(3, 50);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(51, 41);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.numbers);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(149, 3);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(132, 41);
            this.button21.TabIndex = 20;
            this.button21.Text = "Clear";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Location = new System.Drawing.Point(3, 3);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(140, 41);
            this.btnBackSpace.TabIndex = 21;
            this.btnBackSpace.Text = "<--";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // txtdisplay
            // 
            this.txtdisplay.BackColor = System.Drawing.Color.White;
            this.txtdisplay.Location = new System.Drawing.Point(12, 13);
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.ReadOnly = true;
            this.txtdisplay.Size = new System.Drawing.Size(285, 27);
            this.txtdisplay.TabIndex = 1;
            this.txtdisplay.Click += new System.EventHandler(this.numbers);
            this.txtdisplay.TextChanged += new System.EventHandler(this.txtdisplay_TextChanged);
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(12, 46);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(111, 41);
            this.btnOnOff.TabIndex = 16;
            this.btnOnOff.Text = "ON";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 340);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.txtdisplay);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button btnsin;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btncos;
        private System.Windows.Forms.Button btndivid;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnabs;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnpow;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox txtdisplay;
        private System.Windows.Forms.Button btnOnOff;
    }
}

