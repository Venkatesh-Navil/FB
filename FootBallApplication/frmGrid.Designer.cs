namespace FootBallApplication
{
    partial class frmGrid
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
            this.gvTeam = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // gvTeam
            // 
            this.gvTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTeam.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gvTeam.BackgroundColor = System.Drawing.Color.Khaki;
            this.gvTeam.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvTeam.Location = new System.Drawing.Point(0, 1);
            this.gvTeam.Name = "gvTeam";
            this.gvTeam.RowHeadersVisible = false;
            this.gvTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTeam.Size = new System.Drawing.Size(554, 208);
            this.gvTeam.TabIndex = 32;
            this.gvTeam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTeam_CellClick);
            // 
            // frmGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 209);
            this.Controls.Add(this.gvTeam);
            this.Name = "frmGrid";
            this.Text = "frmGrid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGrid_FormClosing);
            this.Load += new System.EventHandler(this.frmGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvTeam;


    }
}