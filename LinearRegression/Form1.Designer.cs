namespace LinearRegression
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
            this.btnSolve = new System.Windows.Forms.Button();
            this.txtTvBudget = new System.Windows.Forms.TextBox();
            this.txtNewspaperBudget = new System.Windows.Forms.TextBox();
            this.txtRadioBudget = new System.Windows.Forms.TextBox();
            this.lblPredictedSales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(172, 221);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(4);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(100, 28);
            this.btnSolve.TabIndex = 0;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // txtTvBudget
            // 
            this.txtTvBudget.Location = new System.Drawing.Point(172, 68);
            this.txtTvBudget.Margin = new System.Windows.Forms.Padding(4);
            this.txtTvBudget.Name = "txtTvBudget";
            this.txtTvBudget.Size = new System.Drawing.Size(132, 22);
            this.txtTvBudget.TabIndex = 1;
            // 
            // txtNewspaperBudget
            // 
            this.txtNewspaperBudget.Location = new System.Drawing.Point(172, 163);
            this.txtNewspaperBudget.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewspaperBudget.Name = "txtNewspaperBudget";
            this.txtNewspaperBudget.Size = new System.Drawing.Size(132, 22);
            this.txtNewspaperBudget.TabIndex = 2;
            // 
            // txtRadioBudget
            // 
            this.txtRadioBudget.Location = new System.Drawing.Point(172, 115);
            this.txtRadioBudget.Margin = new System.Windows.Forms.Padding(4);
            this.txtRadioBudget.Name = "txtRadioBudget";
            this.txtRadioBudget.Size = new System.Drawing.Size(132, 22);
            this.txtRadioBudget.TabIndex = 3;
            // 
            // lblPredictedSales
            // 
            this.lblPredictedSales.AutoSize = true;
            this.lblPredictedSales.Location = new System.Drawing.Point(186, 300);
            this.lblPredictedSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPredictedSales.Name = "lblPredictedSales";
            this.lblPredictedSales.Size = new System.Drawing.Size(0, 16);
            this.lblPredictedSales.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prediction:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "TvBudget";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "RadioBudget";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "NewsPaperBudget";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 435);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPredictedSales);
            this.Controls.Add(this.txtRadioBudget);
            this.Controls.Add(this.txtNewspaperBudget);
            this.Controls.Add(this.txtTvBudget);
            this.Controls.Add(this.btnSolve);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TextBox txtTvBudget;
        private System.Windows.Forms.TextBox txtNewspaperBudget;
        private System.Windows.Forms.TextBox txtRadioBudget;
        private System.Windows.Forms.Label lblPredictedSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

