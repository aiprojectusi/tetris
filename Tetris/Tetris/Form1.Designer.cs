namespace Tetris
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
            this.blocksDataGrid = new System.Windows.Forms.DataGridView();
            this.lblScore = new System.Windows.Forms.Label();
            this.nextGridView = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.blocksDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // blocksDataGrid
            // 
            this.blocksDataGrid.AllowUserToAddRows = false;
            this.blocksDataGrid.AllowUserToDeleteRows = false;
            this.blocksDataGrid.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.blocksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blocksDataGrid.GridColor = System.Drawing.SystemColors.WindowText;
            this.blocksDataGrid.Location = new System.Drawing.Point(12, 12);
            this.blocksDataGrid.Name = "blocksDataGrid";
            this.blocksDataGrid.ReadOnly = true;
            this.blocksDataGrid.Size = new System.Drawing.Size(210, 470);
            this.blocksDataGrid.TabIndex = 0;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(228, 142);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(115, 31);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 0";
            // 
            // nextGridView
            // 
            this.nextGridView.AllowUserToAddRows = false;
            this.nextGridView.AllowUserToDeleteRows = false;
            this.nextGridView.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.nextGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nextGridView.GridColor = System.Drawing.SystemColors.Desktop;
            this.nextGridView.Location = new System.Drawing.Point(234, 12);
            this.nextGridView.Name = "nextGridView";
            this.nextGridView.ReadOnly = true;
            this.nextGridView.Size = new System.Drawing.Size(123, 103);
            this.nextGridView.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(254, 398);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 497);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nextGridView);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.blocksDataGrid);
            this.Name = "Form1";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.blocksDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView blocksDataGrid;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.DataGridView nextGridView;
        private System.Windows.Forms.Button btnStart;
    }
}

