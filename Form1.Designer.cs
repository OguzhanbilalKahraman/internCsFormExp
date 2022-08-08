
namespace wfa
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
            this.btnClick = new System.Windows.Forms.Button();
            this.btnFail3 = new System.Windows.Forms.Button();
            this.btnFail1 = new System.Windows.Forms.Button();
            this.btnSucces = new System.Windows.Forms.Button();
            this.btnFail2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.White;
            this.btnClick.Location = new System.Drawing.Point(330, 207);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(100, 56);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Tikla";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            this.btnClick.MouseLeave += new System.EventHandler(this.btnClick_MouseLeave);
            this.btnClick.MouseHover += new System.EventHandler(this.btnClick_MouseHover);
            // 
            // btnFail3
            // 
            this.btnFail3.Location = new System.Drawing.Point(55, 73);
            this.btnFail3.Name = "btnFail3";
            this.btnFail3.Size = new System.Drawing.Size(75, 23);
            this.btnFail3.TabIndex = 1;
            this.btnFail3.UseVisualStyleBackColor = true;
            this.btnFail3.MouseEnter += new System.EventHandler(this.btnFail3_MouseEnter);
            // 
            // btnFail1
            // 
            this.btnFail1.Location = new System.Drawing.Point(630, 73);
            this.btnFail1.Name = "btnFail1";
            this.btnFail1.Size = new System.Drawing.Size(75, 23);
            this.btnFail1.TabIndex = 1;
            this.btnFail1.UseVisualStyleBackColor = true;
            this.btnFail1.MouseEnter += new System.EventHandler(this.btnFail3_MouseEnter);
            // 
            // btnSucces
            // 
            this.btnSucces.Location = new System.Drawing.Point(630, 367);
            this.btnSucces.Name = "btnSucces";
            this.btnSucces.Size = new System.Drawing.Size(75, 23);
            this.btnSucces.TabIndex = 1;
            this.btnSucces.UseVisualStyleBackColor = true;
            this.btnSucces.MouseEnter += new System.EventHandler(this.btnSucces_MouseEnter);
            // 
            // btnFail2
            // 
            this.btnFail2.Location = new System.Drawing.Point(55, 367);
            this.btnFail2.Name = "btnFail2";
            this.btnFail2.Size = new System.Drawing.Size(75, 23);
            this.btnFail2.TabIndex = 1;
            this.btnFail2.UseVisualStyleBackColor = true;
            this.btnFail2.MouseEnter += new System.EventHandler(this.btnFail3_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFail2);
            this.Controls.Add(this.btnSucces);
            this.Controls.Add(this.btnFail1);
            this.Controls.Add(this.btnFail3);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnFail3;
        private System.Windows.Forms.Button btnFail1;
        private System.Windows.Forms.Button btnSucces;
        private System.Windows.Forms.Button btnFail2;
    }
}

