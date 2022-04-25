
namespace CV09
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.clb = new System.Windows.Forms.CheckedListBox();
            this.add_to_clb = new System.Windows.Forms.Button();
            this.add_to_lb = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.ComboBox();
            this.lb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clb
            // 
            this.clb.FormattingEnabled = true;
            this.clb.Location = new System.Drawing.Point(219, 12);
            this.clb.Name = "clb";
            this.clb.Size = new System.Drawing.Size(120, 184);
            this.clb.TabIndex = 0;
            // 
            // add_to_clb
            // 
            this.add_to_clb.Location = new System.Drawing.Point(138, 12);
            this.add_to_clb.Name = "add_to_clb";
            this.add_to_clb.Size = new System.Drawing.Size(75, 186);
            this.add_to_clb.TabIndex = 1;
            this.add_to_clb.Text = "Vyber dané barvy";
            this.add_to_clb.UseVisualStyleBackColor = true;
            this.add_to_clb.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_to_lb
            // 
            this.add_to_lb.Location = new System.Drawing.Point(11, 231);
            this.add_to_lb.Name = "add_to_lb";
            this.add_to_lb.Size = new System.Drawing.Size(121, 22);
            this.add_to_lb.TabIndex = 2;
            this.add_to_lb.Text = "přidat";
            this.add_to_lb.UseVisualStyleBackColor = true;
            this.add_to_lb.Click += new System.EventHandler(this.add_to_lb_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 79);
            this.button3.TabIndex = 3;
            this.button3.Text = "konec";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(11, 259);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(121, 24);
            this.remove.TabIndex = 4;
            this.remove.Text = "smazat";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(11, 204);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(121, 21);
            this.cb.TabIndex = 5;
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(12, 12);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(120, 186);
            this.lb.TabIndex = 6;
            this.lb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 292);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.add_to_lb);
            this.Controls.Add(this.add_to_clb);
            this.Controls.Add(this.clb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "CV09";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb;
        private System.Windows.Forms.Button add_to_clb;
        private System.Windows.Forms.Button add_to_lb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.ListBox lb;
    }
}

