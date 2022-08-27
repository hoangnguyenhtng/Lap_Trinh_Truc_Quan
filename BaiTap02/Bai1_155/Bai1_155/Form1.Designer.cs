namespace Bai1_155
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnResult = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnResult.Enabled = false;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.Black;
            this.btnResult.Location = new System.Drawing.Point(80, 253);
            this.btnResult.Margin = new System.Windows.Forms.Padding(6);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(123, 43);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(280, 253);
            this.btnReload.Margin = new System.Windows.Forms.Padding(6);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(123, 43);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(474, 253);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 43);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter month:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter year:";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(229, 43);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(334, 31);
            this.txtMonth.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtMonth, "Nhap di thang ngu");
            this.txtMonth.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
            this.txtMonth.Enter += new System.EventHandler(this.txtMonth_Enter);
            this.txtMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonth_KeyPress);
            this.txtMonth.Leave += new System.EventHandler(this.txtMonth_Leave);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(229, 108);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(334, 31);
            this.txtYear.TabIndex = 6;
            this.txtYear.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
            this.txtYear.Enter += new System.EventHandler(this.txtMonth_Enter);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonth_KeyPress);
            this.txtYear.Leave += new System.EventHandler(this.txtMonth_Leave);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(161, 179);
            this.lbResult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(72, 24);
            this.lbResult.TabIndex = 7;
            this.lbResult.Text = "Result: ";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Nhap di";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(674, 330);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Buoi 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

