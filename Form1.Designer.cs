﻿
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnZerar = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Cursor = System.Windows.Forms.Cursors.No;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 48);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(255, 38);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.Color.Transparent;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.Location = new System.Drawing.Point(27, 57);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 25);
            this.lblOperacao.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(12, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(63, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Raiz";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(117, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "PoT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(169, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 39);
            this.button4.TabIndex = 5;
            this.button4.Text = "+/-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.Location = new System.Drawing.Point(221, 128);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(46, 39);
            this.btnApagar.TabIndex = 6;
            this.btnApagar.Text = "Limpar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(221, 173);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(46, 39);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "CE";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiv.Location = new System.Drawing.Point(169, 173);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(46, 39);
            this.btnDiv.TabIndex = 10;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btn9
            // 
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Location = new System.Drawing.Point(117, 173);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(46, 39);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Location = new System.Drawing.Point(63, 173);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 39);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Location = new System.Drawing.Point(12, 173);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 39);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnZerar
            // 
            this.btnZerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZerar.Location = new System.Drawing.Point(221, 218);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(46, 39);
            this.btnZerar.TabIndex = 16;
            this.btnZerar.Text = "C";
            this.btnZerar.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            this.btnMult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMult.Location = new System.Drawing.Point(169, 218);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(46, 39);
            this.btnMult.TabIndex = 15;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btn6
            // 
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Location = new System.Drawing.Point(117, 218);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(46, 39);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Location = new System.Drawing.Point(63, 218);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(48, 39);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Location = new System.Drawing.Point(12, 218);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 39);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnResult
            // 
            this.btnResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResult.Location = new System.Drawing.Point(221, 263);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(46, 84);
            this.btnResult.TabIndex = 21;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnSub
            // 
            this.btnSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub.Location = new System.Drawing.Point(169, 263);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(46, 39);
            this.btnSub.TabIndex = 20;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btn3
            // 
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Location = new System.Drawing.Point(117, 263);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(46, 39);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Location = new System.Drawing.Point(63, 263);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(48, 39);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Location = new System.Drawing.Point(12, 263);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 39);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoma.Location = new System.Drawing.Point(169, 308);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(46, 39);
            this.btnSoma.TabIndex = 25;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPoint.Location = new System.Drawing.Point(117, 308);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(46, 39);
            this.btnPoint.TabIndex = 24;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btn0
            // 
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.Location = new System.Drawing.Point(12, 308);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(99, 39);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 373);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtResultado);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btn0;
    }
}

